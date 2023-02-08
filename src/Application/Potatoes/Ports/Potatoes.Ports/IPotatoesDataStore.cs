using Potatoes.Domain;

namespace Potatoes.Ports
{
    public interface IPotatoesDataStore
    {
        Potato GetById(int id);
    }
}
