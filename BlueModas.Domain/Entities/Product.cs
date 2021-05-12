using BlueModas.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain.Entities
{
    public class Product : Entity
    {
        protected Product()
        {

        }

        public Product(int id, string name, string description, double price, CategoryEnum category, SizeEnum size, Gender gender, int amount) : 
            this(name, description, price, category, size, gender, amount)
        {
            Id = id;
        }

        public Product(string name, string description, double price, CategoryEnum category, SizeEnum size, Gender gender, int amount)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Size = size;
            Gender = gender;
            Amount = amount;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public double Price { get; private set; }
        public CategoryEnum Category { get; private set; }
        public SizeEnum Size { get; private set; }
        public Gender Gender { get; private set; }
        public int Amount { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; } 

        public void Update(string name, string description, double price, CategoryEnum category, SizeEnum size, Gender gender, int amount)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Size = size;
            Gender = gender;
            Amount = amount;
        }

    }
}
