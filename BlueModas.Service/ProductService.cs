using BlueModas.Domain;
using BlueModas.Domain.Entities;
using BlueModas.Domain.Enumerators;
using BlueModas.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Service
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        ProductDto GetById(int id);
        List<ProductDto> GetByCategory(CategoryEnum category);
        List<ProductDto> GetByGender(Gender gender);
        Task<ResponseDto> Create(ProductDto productDto);
        Task<ResponseDto> Update(ProductDto productDto);
        Task<ResponseDto> Delete(int id);
        bool ProductExists(int id);
    }

    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository repository)
        {
            this.repository = repository;
        }

        public List<ProductDto> GetAll()
        {
            List<ProductDto> productList = new List<ProductDto>();
            var products = repository.Query<Product>().OrderBy(c => c.Category).ToList();
            foreach(var product in products)
            {
                productList.Add(new ProductDto(product));
            }

            return productList;

        }

        public List<ProductDto> GetByCategory(CategoryEnum category)
        {
            List<ProductDto> productList = new List<ProductDto>();
            var products = repository.Query<Product>().Where(x => x.Category == category).OrderBy(c => c.Name).ToList();
            foreach (var product in products)
            {
                productList.Add(new ProductDto(product));
            }

            return productList;
        }

        public List<ProductDto> GetByGender(Gender gender)
        {
            List<ProductDto> productList = new List<ProductDto>();
            var products = repository.Query<Product>().Where(x => x.Gender == gender).OrderBy(c => c.Name).ToList();
            foreach (var product in products)
            {
                productList.Add(new ProductDto(product));
            }

            return productList;
        }

        public ProductDto GetById(int id)
        {
            var product = repository.Query<Product>().FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return null;
            }

            return new ProductDto(product);
        }

        public async Task<ResponseDto> Create(ProductDto productDto)
        {
            var product = new Product(productDto.Name, productDto.Description, productDto.Price, productDto.Category, productDto.Size, productDto.Gender, productDto.Amount);
            await repository.CreateAsync(product);
            await repository.SaveChangesAsync();

            return new ResponseDto().Created();
        }

        public async Task<ResponseDto> Delete(int id)
        {
            var extist = ProductExists(id);
            if (!extist)
            {
                return new ResponseDto().NotFound("Produto não encontrado");
            }
            else
            {
                var product = repository.Query<Product>().FirstOrDefault(x => x.Id == id);
                repository.Remove(product);
                await repository.SaveChangesAsync();

                return new ResponseDto().Executed();
            }
        }

        public async Task<ResponseDto> Update(ProductDto productDto)
        {
            var product = repository.Query<Product>().FirstOrDefault(x => x.Id == productDto.Id);

            if(product == null)
            {
                return new ResponseDto().NotFound("Produto não encontrado");
            }

            product.Update(productDto.Name, productDto.Description, productDto.Price, productDto.Category, productDto.Size, productDto.Gender, productDto.Amount);

            await repository.SaveChangesAsync();
            return new ResponseDto().Executed();
        }

        public bool ProductExists(int id)
        {
            return repository.Query<Product>().Any(p => p.Id == id);
        }
    }
}
