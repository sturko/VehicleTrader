using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VehicleTrader.Data.Extention
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(GetConnectionString(configuration), b => b.MigrationsAssembly("VehicleTrader.Data")));

            return services;
        }

        /// <summary>
        /// Get connection string depending on environment
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static string GetConnectionString(IConfiguration configuration)
        {
            return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production"
                ? configuration.GetConnectionString("AppConnectionProd")
                : configuration.GetConnectionString("AppConnection");
        }
    }
}