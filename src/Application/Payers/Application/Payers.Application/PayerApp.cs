using Payers.UseCases;

namespace Payers.Application
{
    public class PayerApp
    {
        private readonly PayerUseCase payerUseCase;

        public PayerApp(PayerUseCase payerUseCase)
        {
            this.payerUseCase = payerUseCase;
        }
    }
}