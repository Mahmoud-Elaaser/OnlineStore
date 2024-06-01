using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class Clothing : Product
    {
        public string Size { get; set; }

        public Clothing(int id, string name, decimal price, string size, int availableQuantity)
            : base(id, name, price, availableQuantity)
        {
            Size = size;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine($"Clothing - ID: {Id}, Name: {Name}, Price: {Price:C}, Size: {Size}, Available Quantity: {AvailableQuantity}");
        }
    }
}
