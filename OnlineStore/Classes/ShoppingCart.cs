using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class ShoppingCart
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void DisplayCart()
        {
            Console.WriteLine($"Shopping Cart for {Customer.Name}");
            foreach (var product in Products)
            {
                product.DisplayProduct();
            }
        }

        public Order Checkout()
        {
            Order order = new Order(new Random().Next(1000, 9999), Customer);
            foreach (var product in Products)
            {
                order.AddProduct(product);
            }
            Products.Clear();
            return order;
        }
    }
}
