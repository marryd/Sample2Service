using Potatoes.Domain;

namespace Contracts
{
    public interface IPotatoesDataStore
    {
        Potato GetById(int id);
    }
}
