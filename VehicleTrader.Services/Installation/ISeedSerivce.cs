namespace VehicleTrader.Services.Installation
{
    public interface ISeedSerivce
    {
        Task InstallDataAsync(IServiceProvider services);
    }
}