using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class VehicleModel : Entity, IEntity<int>
    {
        public string ModelName { get; set; }

        public VehicleFactory VehicleFactory { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}