using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace Models
{
    public class GenericVehicle<TVehicle> : IVehicle<TVehicle>
    {
        public GenericVehicle(UniversalVehicleData universalVehicleData)
        {
            DataJson = universalVehicleData.DataJson;
            VehicleName = universalVehicleData.VehicleName;
            RegistrationNumber = universalVehicleData.RegistrationNumber;
        }


        public string DataJson { get; set; }

        public string VehicleName { get; set; }

        public string RegistrationNumber { get; set; }

        public string VehicleType { get; set; }

        public TVehicle Data {
            
            get {

               
                    var deserializationResult = JsonConvert.DeserializeObject<TVehicle>(this.DataJson);
                    return deserializationResult;
          

            } 
        }

    }
}