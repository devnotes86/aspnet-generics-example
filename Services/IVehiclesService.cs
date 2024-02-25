using Models;

namespace Services
{
    public interface IVehiclesService
    {
        IVehicle GetVehicleDetails(UniversalVehicleData universalVehicleData);
    }
}