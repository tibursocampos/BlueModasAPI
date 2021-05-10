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

        public Order(int id, int clientId, int cartId) : this (clientId, cartId)
        {
            Id = id;
        }

        public Order(int clientId, int cartId)
        {
            ClientId = clientId;
            CartId = cartId;
        }

        public int ClientId { get; private set; }
        public int CartId { get; private set; }
        public Client Client { get; private set; }
        public Cart Cart { get; private set; }
        public ICollection<Product> Products { get; set; }

    }
}
