using Models;
using Models.VehicleTypeDefinitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VehiclesService : IVehiclesService
    {
        // returning serialized JSON
        // item will be deserialized in the view
        public IVehicle GetVehicleDetails(UniversalVehicleData universalVehicleData)
        {

            switch (universalVehicleData.VehicleType)
            {
                case VehicleTypes.RacingCar:
                    return (IVehicle)new GenericVehicle<RacingCar>(universalVehicleData);
                    break;
                case VehicleTypes.RoadBike:
                    return (IVehicle)new GenericVehicle<RoadBike>(universalVehicleData);
                    break;

                default: throw new Exception("Vehicle type not found");
            }



        }
    }
}
