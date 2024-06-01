using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal TotalMoney { get; set; }

        public Customer(int id, string name, string email, decimal totalMoney)
        {
            Id = id;
            Name = name;
            Email = email;
            TotalMoney = totalMoney;
        }
    }

}
