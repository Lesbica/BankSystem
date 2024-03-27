using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Mediator
{
    public class VisaCard : BankCard
    {
        public VisaCard(IBankMediator mediator) : base(mediator) { }

        public override void MakePayment(int amount)
        {
            mediator.ProcessPayment("Visa", amount);
        }
    }
}
