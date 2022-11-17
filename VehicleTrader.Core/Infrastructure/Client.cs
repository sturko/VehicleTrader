namespace VehicleTrader.Core.Infrastructure
{
    /// <summary>
    /// Identity Server client identifier
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Client id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Client friendly name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Client base url
        /// </summary>
        public string ClientUrl { get; set; }
    }
}