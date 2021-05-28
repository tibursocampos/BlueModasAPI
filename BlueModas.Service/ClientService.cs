using BlueModas.Domain;
using BlueModas.Domain.Entities;
using BlueModas.Service.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueModas.Service
{
    public interface IClientService
    {
        List<ClientDto> GetAll();
        List<ClientDto> GetByName(string name);
        List<ClientDto> GetByPhone(string phone);
        ClientDto GetById(int id);
        ClientDto GetByEmail(string email);
        Task<ResponseDto> Create(ClientDto productDto);
        Task<ResponseDto> Update(ClientDto productDto);
        Task<ResponseDto> Delete(int id);
        bool ClientExists(int id);
    }

    public class ClientService : IClientService
    {
        private readonly IRepository repository;

        public ClientService(IRepository repository)
        {
            this.repository = repository;
        }

        public List<ClientDto> GetAll()
        {
            List<ClientDto> clientList = new List<ClientDto>();
            var clients = repository.Query<Client>().OrderBy(x => x.Name).ToList();
            foreach(var client in clients)
            {
                clientList.Add(new ClientDto(client));
            }

            return clientList;
        }

        public ClientDto GetByEmail(string email)
        {
            var client = repository.Query<Client>().FirstOrDefault(x => x.Email == email);
            if(client == null)
            {
                return null;
            }
            return new ClientDto(client);
        }

        public ClientDto GetById(int id)
        {
            var client = repository.Query<Client>().FirstOrDefault(x => x.Id == id);
            if(client == null)
            {
                return null;
            }
            return new ClientDto(client);
        }

        public List<ClientDto> GetByName(string name)
        {
            List<ClientDto> clientList = new List<ClientDto>();
            var clients = repository.Query<Client>().Where(x => x.Name == name).OrderBy(x => x.Phone).ToList();
            foreach(var client in clients)
            {
                clientList.Add(new ClientDto(client));
            }

            return clientList;
        }

        public List<ClientDto> GetByPhone(string phone)
        {
            List<ClientDto> clientList = new List<ClientDto>();
            var clients = repository.Query<Client>().Where(x => x.Phone == phone).OrderBy(x => x.Name).ToList();
            foreach (var client in clients)
            {
                clientList.Add(new ClientDto(client));
            }

            return clientList;
        }

        public async Task<ResponseDto> Create(ClientDto clientDto)
        {
            var client = new Client(clientDto.Name, clientDto.Email, clientDto.Password, clientDto.Phone);
            await repository.CreateAsync(client);
            await repository.SaveChangesAsync();

            return new ResponseDto().Created();
        }

        public async Task<ResponseDto> Delete(int id)
        {
            var exist = ClientExists(id);
            if (!exist)
            {
                return new ResponseDto().NotFound("Cliente não encontrado");
            }
            else
            {
                var client = repository.Query<Client>().FirstOrDefault(x => x.Id == id);
                repository.Remove(client);
                await repository.SaveChangesAsync();

                return new ResponseDto().Executed();
            }
        }        

        public async Task<ResponseDto> Update(ClientDto clientDto)
        {
            var client = repository.Query<Client>().FirstOrDefault(x => x.Id == clientDto.Id);

            if (client == null)
            {
                return new ResponseDto().NotFound("Cliente não encontrado");
            }

            client.Update(clientDto.Name, clientDto.Email, clientDto.Password, clientDto.Phone);
            await repository.SaveChangesAsync();

            return new ResponseDto().Executed();
        }

        public bool ClientExists(int id)
        {
            return repository.Query<Client>().Any(x => x.Id == id);
        }
    }
}
