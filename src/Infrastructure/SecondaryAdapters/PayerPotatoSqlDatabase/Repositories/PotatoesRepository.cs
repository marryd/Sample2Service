using Potatoes.Domain;
using Potatoes.Ports;
using System.Data;

namespace Database.Repositories
{
    internal class PotatoesRepository : IPotatoesDataStore
    {
        private readonly IDbConnection dbConnection;

        public PotatoesRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public Potato GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
