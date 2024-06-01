using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class PayPalPayment : IPaymentMethod
    {
        public string Email { get; set; }

        public PayPalPayment(string email)
        {
            Email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} with PayPal: {Email}");
        }

        public bool Validate()
        {
            // Basic validation: check if the email format is valid
            return Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
