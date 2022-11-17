using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class VehicleGeneration : Entity, IEntity<int>
    {
        public string GenerationName { get; set; }

        public VehicleModel VehicleModel { get; set; }
    }
}