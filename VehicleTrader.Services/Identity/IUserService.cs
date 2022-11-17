using VehicleTrader.Core.Domain;

namespace VehicleTrader.Services.Identity
{
    public interface IUserService
    {
        Task<ApplicationUser> GetByUserNameAsync(string username);
        Task<ApplicationUser> GetByUserEmailAsync(string userEmail);
    }
}