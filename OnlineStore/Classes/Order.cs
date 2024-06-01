using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount { get; set; }

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            if (product.AvailableQuantity > 0) 
            {
                Products.Add(product);
                product.AvailableQuantity--; // Decrease available quantity
                TotalAmount += product.Price;
            }
            else
            {
                Console.WriteLine($"Product '{product.Name}' is out of stock and cannot be added to the order.");
            }
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {Customer.Name}, Total Amount: {TotalAmount:C}");
            foreach (var product in Products)
            {
                product.DisplayProduct();
            }
        }
    }
}
