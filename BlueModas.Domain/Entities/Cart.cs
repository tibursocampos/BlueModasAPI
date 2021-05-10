using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain.Entities
{
    public class Cart : Entity
    {
        protected Cart()
        {

        }

        public Cart(int id, int clientId, int orderId, int amount, double total) : this(clientId, orderId, amount, total)
        {
            Id = id;
        }

        public Cart(int clientId, int orderId, int amount, double total)
        {
            ClientId = clientId;
            OrderId = orderId;
            Amount = amount;
            Total = total;
        }

        public int ClientId { get; private set; }
        public int OrderId { get; private set; }
        public int Amount { get; private set; }
        public double Total { get; private set; }
        public ICollection<Product> Products { get; private set; }
        public Client Client { get; private set; }
        public Order Order { get; private set; }

        public void Update(int clientId, int orderId, int amount, double total)
        {
            ClientId = clientId;
            OrderId = orderId;
            Amount = amount;
            Total = total;
        }
    }
}
