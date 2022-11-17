using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.RegularExpressions;
using VehicleTrader.Core.Consts;
using VehicleTrader.Core.Domain;
using System.Linq.Expressions;

namespace VehicleTrader.Services.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterAsync(ApplicationUser user, string password)
        {
            user.FirstName = Regex.Replace(user.FirstName, @"\s+", " ").Trim();
            user.LastName = Regex.Replace(user.LastName, @"\s+", " ").Trim();

            var result = await _userManager.CreateAsync(user, password);
            return result;
        }

        public async Task<string> GetJwtAsync(string userEmail)
        {
            string tokenValue;

            try
            {
                var user = await _userManager.FindByEmailAsync(userEmail);
                var roles = await _userManager.GetRolesAsync(user);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim(ClaimTypes.Name, user.LastName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                    _configuration.GetSection("AppSettings:Token").Value));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds);

                tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            }
            catch (Exception)
            {
                tokenValue = null;
            }

            return tokenValue;
        }
    }
}