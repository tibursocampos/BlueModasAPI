using BlueModas.Domain.Entities;
using BlueModas.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Service.Dto
{
    public class ProductDto
    {
        public ProductDto()
        {

        }

        public ProductDto(Product product)
        {
            if (product == null) return;
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Image = product.Image;
            Price = product.Price;
            Category = product.Category;
            Size = product.Size;
            Gender = product.Gender;
            Amount = product.Amount;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public CategoryEnum Category { get; set; }
        public SizeEnum Size { get; set; }
        public Gender Gender { get; set; }
        public int Amount { get; set; }
    }
}
