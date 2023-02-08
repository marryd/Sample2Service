using Potatoes.Domain;
using Potatoes.Ports;

namespace Potatoes.UseCases
{
    public class PotatoUseCase
    {
        private readonly IPayerSystem payerSystem;

        public PotatoUseCase(IPayerSystem payerSystem)
        {
            this.payerSystem = payerSystem;
        }

        public Potato GetPotato(int id)
        {
            var payer = payerSystem.Get();

            return new Potato(id, "storpotät", payer.Id);
        }
    }
}