using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class CreditCardPayment : IPaymentMethod
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} with Credit Card: {CardNumber}");
        }

        public bool Validate()
        {
            // Basic validation: card number should be 16 digits long and numeric
            return CardNumber.Length == 16 && long.TryParse(CardNumber, out _);
        }
    }
}
