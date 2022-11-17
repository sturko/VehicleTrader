using Microsoft.AspNetCore.Identity;
using VehicleTrader.Core.Domain;

namespace VehicleTrader.Services.Identity
{
    public interface IAuthService
    {
        Task<IdentityResult> RegisterAsync(ApplicationUser user, string password);
        Task<string> GetJwtAsync(string username);
    }
}