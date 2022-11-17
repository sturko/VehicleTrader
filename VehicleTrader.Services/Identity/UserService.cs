using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VehicleTrader.Core.Domain;

namespace VehicleTrader.Services.Identity
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> GetByUserEmailAsync(string userEmail)
        {
            return await _userManager.Users
                .Where(x => x.Email.Equals(userEmail))
                .Include(x => x.Profile)
                .FirstOrDefaultAsync();
        }

        public async Task<ApplicationUser> GetByUserNameAsync(string username)
        {
            return await _userManager.Users
                .Where(x => x.UserName.Equals(username))
                .Include(x => x.Profile)
                .FirstOrDefaultAsync();
        }
    }
}