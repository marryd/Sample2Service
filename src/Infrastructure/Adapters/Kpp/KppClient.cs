using Contracts;

namespace Kpp
{
    public class KppClient : ICostSystem
    {
        private readonly HttpClient client;

        public KppClient(HttpClient client)
        {
            this.client = client;
        }

    }
}