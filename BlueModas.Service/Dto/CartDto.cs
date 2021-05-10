using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Service.Dto
{
    public class CartDto
    {
        public CartDto(Cart cart)
        {
            if (cart == null) return;
            Id = cart.Id;
            ClientId = cart.ClientId;
            OrderId = cart.OrderId;
            Amount = cart.Amount;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public double Total { get; set; }
        public Client Client { get; set; }
        public Order Order { get; set; }
    }
}
