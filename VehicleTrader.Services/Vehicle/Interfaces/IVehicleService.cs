using VehicleTrader.Core.Domain.Vehicle;

namespace VehicleTrader.Services.Vehicle.Interfaces
{
    public interface IVehicleService 
    {
        Task<IList<VehicleFactory>> GetVehicleAsync();
    }
}