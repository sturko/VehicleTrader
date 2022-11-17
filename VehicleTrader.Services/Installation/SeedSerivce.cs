using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace VehicleTrader.Services.Installation
{
    public class SeedSerivce : ISeedSerivce
    {
        public async Task InstallDataAsync(IServiceProvider serviceProvider)
        {
            await CreateUserRoles(serviceProvider);
        }

        private static async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var roles = new[] { "Admin", "User" };

                foreach (var role in roles)
                {
                    var roleExists = await roleManager.RoleExistsAsync(role);

                    if (!roleExists)
                        await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
           
        }
    }
}