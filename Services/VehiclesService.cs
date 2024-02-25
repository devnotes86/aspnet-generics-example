using Models;
using Models.VehicleTypes;
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
        public string GetVehicleDetails(UniversalVehicleData universalVehicleData)
        {


            var carData = new GenericVehicle<Car>(universalVehicleData).Data;

            var serializedcarData = JsonConvert.SerializeObject(carData);


            return serializedcarData;
        }
    }
}
