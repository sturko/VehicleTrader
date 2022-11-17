using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class VehicleModelType : Entity, IEntity<int>
    {
        public string ModelTypeName { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleFactory VehicleFactory { get; set; }
    }
}