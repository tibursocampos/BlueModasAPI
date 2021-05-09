using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain.Entities
{
    public class Order : Entity
    {
        protected Order()
        {

        }

        public Order(int id, int clientId) : this (clientId)
        {
            Id = id;
        }

        public Order(int clientId)
        {
            ClientId = clientId;
        }

        public int ClientId { get; private set; }
        public Client Client { get; private set; }
        public ICollection<Cart> Carts { get; private set; }

    }
}
