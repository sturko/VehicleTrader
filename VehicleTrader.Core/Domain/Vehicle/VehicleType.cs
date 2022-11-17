using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class VehicleType : Entity, IEntity<int>
    {
        public string VehicleTypeName { get; set; }
    }
}