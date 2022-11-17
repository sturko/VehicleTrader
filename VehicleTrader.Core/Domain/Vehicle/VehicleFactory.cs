using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class VehicleFactory : Entity, IEntity<int>
    {
        public string FactoryName { get; set; }

        public VehicleProducingCountry Country { get; set; }
    }
}