using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Service.Dto
{
    public class OrderDto
    {
        public OrderDto(Order order)
        {
            Id = order.Id;
            ClientId = order.ClientId;
            CartId = order.ClientId;
            Client = order.Client;
            Cart = order.Cart;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CartId { get; set; }
        public Client Client { get; set; }
        public Cart Cart { get; set; }
    }
}
