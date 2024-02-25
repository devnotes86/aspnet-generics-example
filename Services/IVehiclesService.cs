using Models;

namespace Services
{
    public interface IVehiclesService
    {
        string GetVehicleDetails(UniversalVehicleData universalVehicleData);
    }
}