using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Mediator
{
    public abstract class BankCard
    {
        protected IBankMediator mediator;

        public BankCard(IBankMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void MakePayment(int amount);
    }
}
