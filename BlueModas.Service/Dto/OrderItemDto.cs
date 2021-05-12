using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Service.Dto
{
    public class OrderItemDto
    {
        public OrderItemDto(OrderItem orderItem)
        {
            OrderId = orderItem.OrderId;
            ProductId = orderItem.ProductId;
            Quantity = orderItem.Quantity;
            Product = orderItem.Product;
            Order = orderItem.Order;
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
