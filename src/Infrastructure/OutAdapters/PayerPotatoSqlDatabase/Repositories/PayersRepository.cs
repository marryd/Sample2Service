using Payers.Domain;
using Payers.Ports;
using System.Data;

namespace Database.Repositories
{
    internal class PayersRepository : IPayersDataStore
    {
        private readonly IDbConnection dbConnection;

        public PayersRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public Payer GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
