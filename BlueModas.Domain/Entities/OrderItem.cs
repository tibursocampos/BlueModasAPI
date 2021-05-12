using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem()
        {

        }

        public OrderItem(int id, int orderId, int productId, int quantity, double price) : this (orderId, productId, quantity, price)
        {
            Id = id;

        }

        public OrderItem(int orderId, int productId, int quantity, double price)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product { get; private set; }
        public Order Order { get; private set; }

        public void Update(int orderId, int productId, int quantity, double price)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
    }
}
