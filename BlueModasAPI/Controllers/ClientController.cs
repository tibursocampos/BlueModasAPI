using BlueModas.Service;
using BlueModas.Service.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueModasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientService clientService;

        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet]
        public ActionResult<List<ClientDto>> GetAll()
        {
            var client = clientService.GetAll();
            return client;
        }

        [HttpGet("{id}")]
        public ActionResult<ClientDto> GetById(int id)
        {
            var client = clientService.GetById(id);
            if(client == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return client;
        }

        [HttpGet("name/{name}")]
        public ActionResult<List<ClientDto>> GetByName(string name)
        {
            var client = clientService.GetByName(name);
            if (client == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return client;
        }

        [HttpGet("phone/{phone}")]
        public ActionResult<List<ClientDto>> GetByPhone(string phone)
        {
            var client = clientService.GetByPhone(phone);
            if (client == null)
            {
                return NotFound("Telefone não encontrado");
            }
            return client;
        }

        [HttpGet("email/{email}")]
        public ActionResult<ClientDto> GetByEmail(string email)
        {
            var client = clientService.GetByEmail(email);
            if (client == null)
            {
                return NotFound("Email não encontrado");
            }
            return client;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto>> Create(ClientDto clientDto)
        {
            var clientCreated = await clientService.Create(clientDto);

            if (!clientCreated.Created().Success)
            {
                return BadRequest(new { message = clientCreated.ErrorMessage });
            }
            else
            {
                return Ok("Cliente adicionado");
            }
        }

        [HttpPut]
        public async Task<ActionResult<ResponseDto>> Update(ClientDto clientDto)
        {
            var response = await clientService.Update(clientDto);
            if (!response.Success)
            {
                return NotFound(new { message = response.ErrorMessage });
            }

            return Ok(response.Success);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto>> Delete(int id)
        {
            var response = await clientService.Delete(id);

            if (!response.Success)
            {
                return BadRequest(new { message = response.ErrorMessage });
            }

            return Ok(response.Success);
        }
    }
}
