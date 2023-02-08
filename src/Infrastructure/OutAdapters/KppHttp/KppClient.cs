
using Payers.Ports;

namespace Kpp
{
    public class KppClient : ICostSystem
    {
        private readonly HttpClient client;

        public KppClient(HttpClient client)
        {
            this.client = client;
        }

        public IEnumerable<object> GetCosts()
        {
            throw new NotImplementedException();
        }
    }
}