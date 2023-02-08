using Payers.Domain;
using Payers.UseCases;

namespace Payers.Facade
{
    public class PayerApp : IPayerApp
    {
        private readonly PayerUseCase payerUseCase;

        public PayerApp(PayerUseCase payerUseCase)
        {
            this.payerUseCase = payerUseCase;
        }

        public Payer Get()
        {
            throw new NotImplementedException();
        }
    }
}