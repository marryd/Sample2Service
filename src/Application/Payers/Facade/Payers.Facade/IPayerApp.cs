using Payers.Domain;

namespace Payers.Facade
{
    public interface IPayerApp {

        Payer Get();
    }
}