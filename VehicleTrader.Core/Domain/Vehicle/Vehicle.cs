using VehicleTrader.Core.Interfaces;

namespace VehicleTrader.Core.Domain.Vehicle
{
    public class Vehicle : Entity, IEntity<int>
    {
        public string VIN { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public int? Dors { get; set; }
        public int? Price { get; set; }
        public bool Used { get; set; }
        public int? Seats { get; set; }
        public int? Odometer { get; set; }

        public virtual Profile Profile { get; set; }
        public VehicleModel VehicleModel { get; set; }
    }
}