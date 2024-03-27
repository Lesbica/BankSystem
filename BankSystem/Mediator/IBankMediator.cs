using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Mediator
{
    public interface IBankMediator
    {
        void ProcessPayment(string cardNumber, int amount);
    }
}
