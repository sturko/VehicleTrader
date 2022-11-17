namespace VehicleTrader.Services.Profile.Interfaces
{
    public interface IProfileService
    {
        void AddProfile(Core.Domain.Profile profile);
        void UpdateProfile(Core.Domain.Profile profile);
        Task<Core.Domain.Profile> GetProfileByIdAsync(int id);
        Core.Domain.Profile GetProfileByUserId(string userId);
    }
}