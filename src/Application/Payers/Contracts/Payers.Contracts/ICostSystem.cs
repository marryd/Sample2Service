namespace Payers.Ports
{
    public interface ICostSystem
    {
        IEnumerable<object> GetCosts();
    }
}
