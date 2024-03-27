using BankSystem.Mediator;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        private PaymentMediator mediator;
        BankCard visaCard;
        BankCard masterCard;


        public Form1()
        {
            InitializeComponent();
            mediator = new PaymentMediator();
            visaCard = new VisaCard(mediator);
            masterCard = new MasterCard(mediator);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mediator.ProcessPayment(textBox1.Text, Int32.Parse(textBox2.Text));
        }
    }
}
