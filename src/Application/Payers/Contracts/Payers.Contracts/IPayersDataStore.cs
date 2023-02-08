using Payers.Domain;

namespace Payers.Ports
{
    public interface IPayersDataStore
    {
        Payer GetById(int id);
    }
}