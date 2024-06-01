using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; } 

        public Product(int id, string name, decimal price, int availableQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            AvailableQuantity = availableQuantity;
        }

        public abstract void DisplayProduct();
    }
}
