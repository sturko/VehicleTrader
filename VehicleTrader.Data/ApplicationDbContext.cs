using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VehicleTrader.Core.Domain;
using VehicleTrader.Core.Domain.Vehicle;
using VehicleTrader.Data.Interfaces;

namespace VehicleTrader.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {}

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleFactory> VehicleFactory { get; set; }
        public DbSet<VehicleGeneration> VehicleGeneration { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }
        public DbSet<VehicleModelType> VehicleModelType { get; set; }
        public DbSet<VehicleProducingCountry> VehicleProducingCountry { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
        public DbSet<Profile> Profile { get; set; }
    }
}