using BlueModas.Domain.Enumerators;
using BlueModas.Service;
using BlueModas.Service.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueModasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public ActionResult<List<ProductDto>> GetAll()
        {
            var product = productService.GetAll();
            return product;
        }

        [HttpGet("categoria/{category}")]
        public ActionResult<List<ProductDto>> GetByCategory(CategoryEnum category)
        {
            var product = productService.GetByCategory(category);
            return product;
        }

        [HttpGet("genero/{gender}")]
        public ActionResult<List<ProductDto>> GetByGender(Gender gender)
        {
            var product = productService.GetByGender(gender);
            return product;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetById(int id)
        {
            var product = productService.GetById(id);
            return product;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto>> Create(ProductDto productDto)
        {
            var productCreated = await productService.Create(productDto);

            if (!productCreated.Created().Success)
            {
                return BadRequest(new { message = productCreated.ErrorMessage });
            }
            else
            {
                return Ok("Produto adicionado");
            }
        }

        [HttpPut]
        public async Task<ActionResult<ResponseDto>> Update(ProductDto productDto)
        {
            var response = await productService.Update(productDto);
            if (!response.Success)
            {
                return NotFound(new { message = response.ErrorMessage });
            }

            return Ok(response.Success);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto>> Delete(int id)
        {
            var response = await productService.Delete(id);

            if (!response.Success)
            {
                return BadRequest(new { message = response.ErrorMessage });
            }

            return Ok(response.Success);
        }
    }
}
