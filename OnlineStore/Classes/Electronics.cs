using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(int id, string name, decimal price, string brand, int availableQuantity)
            : base(id, name, price, availableQuantity)
        {
            Brand = brand;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine($"Electronics - ID: {Id}, Name: {Name}, Price: {Price:C}, Brand: {Brand}, Available Quantity: {AvailableQuantity}");
        }
    }
}
