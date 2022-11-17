using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using VehicleTrader.Core.Repo;
using VehicleTrader.Services.Profile.Interfaces;

namespace VehicleTrader.Services.Profile
{
    public class ProfileService : GeneralService<Core.Domain.Profile>, IProfileService
    {
        public ProfileService(IRepositoryBase<Core.Domain.Profile> repository) 
            : base(repository)
        {}

        public void AddProfile(Core.Domain.Profile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            Repository.Insert(profile);
        }

        public async Task<Core.Domain.Profile> GetProfileByIdAsync(int id)
        {
            return await Repository.Table
                .Include(m => m.ApplicationUser)
                .Include(m => m.OwnVehicles)
                .FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public Core.Domain.Profile GetProfileByUserId(string userId)
        {
            if (userId.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(userId));

            return Repository.Table
                .FirstOrDefault(x => x.ApplicationUserId.Equals(userId));
        }

        public void UpdateProfile(Core.Domain.Profile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            Repository.Update(profile);
        }
    }
}