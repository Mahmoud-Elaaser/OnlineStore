using OnlineStore.Classes;


namespace OnlineStore
{

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string customerEmail = Console.ReadLine();

            Console.Write("Enter the total money you have: ");
            decimal customerMoney;

            
            while (!decimal.TryParse(Console.ReadLine(), out customerMoney) || customerMoney < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid amount of money.");
            }

            Console.WriteLine($"Hello {customerName}, in our online store!");


            Customer customer = new Customer(1, customerName, customerEmail, customerMoney);

            ShoppingCart cart = new ShoppingCart(customer);

            /// Create some products
            List<Product> products = new List<Product>
            {
                new Electronics(1, "Laptop", 1200.99m, "Dell", 25),
                new Electronics(2, "Smartphone", 699.99m, "Samsung", 30),
                new Electronics(3, "Tablet", 329.99m, "Apple", 10),
                new Electronics(4, "Headphones", 59.99m, "Sony", 40),
                new Clothing(5, "T-Shirt", 19.99m, "M", 35),
                new Clothing(6, "Jeans", 49.99m, "L", 65),
                new Clothing(7, "Jacket", 89.99m, "XL", 20),
                new Clothing(8, "Sneakers", 75.99m, "42", 60)
            };

            bool shopping = true;
            while (shopping)
            {
                Console.WriteLine("Available Products:");
                foreach (var product in products)
                {
                    product.DisplayProduct();
                }

                Console.WriteLine("Enter the ID of the product you want to add to the cart " +
                    "(or 'checkout' to proceed to checkout):");
                string input = Console.ReadLine();

                if (input.ToLower() == "checkout")
                {
                    shopping = false;
                    continue;
                }

                if (int.TryParse(input, out int productId))
                {
                    Product selectedProduct = products.Find(p => p.Id == productId);
                    if (selectedProduct != null && selectedProduct.AvailableQuantity > 0)
                    {
                        cart.AddProduct(selectedProduct);
                        Console.WriteLine($"{selectedProduct.Name} added to the cart.");
                    }
                    else if (selectedProduct != null && selectedProduct.AvailableQuantity == 0)
                    {
                        Console.WriteLine("Product is out of stock.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid product ID.");
                }
            }

            bool checkout = true;
            while (checkout)
            {
                // Display the shopping cart
                cart.DisplayCart();

                // Checkout and create an order
                Order order = cart.Checkout();

                if (order.TotalAmount > customer.TotalMoney)
                {
                    Console.WriteLine($"Your order costs {order.TotalAmount:C} " +
                        $"and you have  {customer.TotalMoney:C} only so, you cann't take this order.");
                    break;
                }
                else
                {
                    order.DisplayOrder();
                    checkout = false;

                    // Prompt user for payment method
                    IPaymentMethod payment = null;
                    bool validPayment = false;

                    while (!validPayment)
                    {
                        Console.WriteLine("Choose a payment method:");
                        Console.WriteLine("1. Credit Card");
                        Console.WriteLine("2. PayPal");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            Console.Write("Enter Credit Card Number: ");
                            string cardNumber = Console.ReadLine();
                            payment = new CreditCardPayment(cardNumber);
                        }
                        else if (choice == "2")
                        {
                            Console.Write("Enter PayPal Email: ");
                            string email = Console.ReadLine();
                            payment = new PayPalPayment(email);
                        }
                        else
                        {
                            Console.WriteLine("Invalid payment method selected.");
                            continue;
                        }

                        if (payment.Validate())
                        {
                            validPayment = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid payment details provided. Please try again.");
                        }
                    }

                    // Pay for the order
                    payment.Pay(order.TotalAmount);
                    Console.WriteLine("Order placed successfully!");
                }
            }
        }
    }
}
