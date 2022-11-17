using Microsoft.AspNetCore.Identity;
using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain
{
    public class ApplicationUser : IdentityUser, IEntity<string>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsRemoved { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual Profile Profile { get; set; }
    }
}