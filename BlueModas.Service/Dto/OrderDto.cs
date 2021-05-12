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
            Total = order.Total;
            Client = order.Client;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public double Total { get; set; }
        public Client Client { get; set; }
    }
}
