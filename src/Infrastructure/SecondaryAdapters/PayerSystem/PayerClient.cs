using Payers.Facade;
using Potatoes.Domain;
using Potatoes.Ports;

namespace PayerSystem
{
    public class PayerClient : IPayerSystem
    {
        private readonly IPayerApp payerApp;

        public PayerClient(IPayerApp payerApp)
        {
            this.payerApp = payerApp;
        }

        public Payer Get()
        {
            var p = payerApp.Get();

            return new Payer(p.Id);
        }
    }
}