using Contracts;
using Database.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace Database.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static void AddPayersDataStore(this IServiceCollection sc)
        {
           // sc.AddScoped<IPayersDataStore>(x => new PayersRepository(new SqlConnection("")));
            sc.AddScoped<IPayersDataStore>(x => new PayersRepository(null!));
        }

        public static void AddPotatoesDataStore(this IServiceCollection sc)
        {
            // sc.AddScoped<IPotatoesDataStore>(x => new PotatoesRepository(new SqlConnection("")));
            sc.AddScoped<IPotatoesDataStore>(x => new PotatoesRepository(null!));
        }
    }
}
