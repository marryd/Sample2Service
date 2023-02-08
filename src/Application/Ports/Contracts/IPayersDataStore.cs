using Payers.Domain;

namespace Contracts
{
    public interface IPayersDataStore
    {
        Payer GetById(int id);
    }
}