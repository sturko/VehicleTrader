namespace VehicleTrader.Core.Domain
{
    public class Profile : Entity
    {
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public virtual ICollection<Vehicle.Vehicle> OwnVehicles { get; set; }
    }
}