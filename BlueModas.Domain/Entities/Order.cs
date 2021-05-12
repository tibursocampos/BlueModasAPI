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

        public Order(int id, int clientId, double total) : this (clientId, total)
        {
            Id = id;
        }

        public Order(int clientId, double total)
        {
            ClientId = clientId;
            Total = total;
        }

        public int ClientId { get; private set; }
        public double Total { get; private set; }
        public Client Client { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

        public void Update(int clientId, double total)
        {
            ClientId = clientId;
            Total = total;
        }

    }
}
