using Contracts;
using Payers.Domain;

namespace Payers.UseCases
{
    public class PayerUseCase
    {
        private readonly IPayersDataStore payersDataStore;

        public PayerUseCase(IPayersDataStore payersDataStore)
        {
            this.payersDataStore = payersDataStore;
        }

        public Payer FetchPayer(int id)
        {
            return payersDataStore.GetById(id);
        }
    }
}