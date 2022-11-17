using Microsoft.EntityFrameworkCore;
using VehicleTrader.Core.Domain.Vehicle;
using VehicleTrader.Core.Repo;
using VehicleTrader.Services.Vehicle.Interfaces;

namespace VehicleTrader.Services.Vehicle
{
    public class VehicleService : GeneralService<VehicleFactory>, IVehicleService
    {
        public VehicleService(IRepositoryBase<VehicleFactory> repository) 
            : base(repository)
        {}

        public async Task<IList<VehicleFactory>> GetVehicleAsync()
        {
            return await Repository.GetAll().ToListAsync();
        }
    }
}