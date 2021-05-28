using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Service.Dto
{
    public class ClientDto
    {
        public ClientDto()
        {
                
        }

        public ClientDto(Client client)
        {
            if (client == null) return;
            Id = client.Id;
            Name = client.Name;
            Email = client.Email;
            Password = client.Password;
            Phone = client.Phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
