using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class VehicleProducingCountry : Entity, IEntity<int>
    {
        public string Country { get; set; }
    }
}
