using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Mediator
{
    public class PaymentMediator : IBankMediator
    {
        public void ProcessPayment(string cardNumber, int amount)
        {
            string cardType = GetCardType(cardNumber);
            switch (cardType)
            {
                case "Visa":
                    ProcessVisaPayment(cardNumber, amount);
                    break;
                case "MasterCard":
                    ProcessMasterCardPayment(cardNumber, amount);
                    break;
                default:
                    Console.WriteLine("Невідомий тип картки.");
                    break;
            }
        }

        private string GetCardType(string cardNumber)
        {
            // Припустимо, що '4' означає Visa, а '5' - MasterCard
            if (cardNumber.StartsWith("4"))
            {
                return "Visa";
            }
            else if (cardNumber.StartsWith("5"))
            {
                return "MasterCard";
            }
            else
            {
                return "Unknown";
            }
        }

        private void ProcessVisaPayment(string cardNumber, int amount)
        {
            // Логіка оплати для Visa
            MessageBox.Show($"Оплата Visa карткою {cardNumber} на суму {amount} грн.");
        }

        private void ProcessMasterCardPayment(string cardNumber, int amount)
        {
            // Логіка оплати для MasterCard
            MessageBox.Show($"Оплата MasterCard карткою {cardNumber} на суму {amount} грн.");
        }
    }

}
