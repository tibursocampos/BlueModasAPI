using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain.Entities
{
    public class Client : Entity
    {
        public Client(int id, string name, string email, string password, string phone) : this(name, email, password, phone)
        {
            Id = id;
        }

        public Client(string name, string email, string password, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }

        protected Client()
        {
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Order> Orders { get; private set; }

        public void Update(string name, string email, string password, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }

}
