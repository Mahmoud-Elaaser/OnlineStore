using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Classes
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
        bool Validate();
    }
}
