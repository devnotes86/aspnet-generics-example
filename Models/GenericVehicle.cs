using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace Models
{
    public class GenericVehicle<TVehicle> : IVehicle //<TVehicle>
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


        // generic type property
        public TVehicle Data {
            
            get {  
                    // at this point - a JSON string is deserialized to an injected Type (ex Coach, RoadBike or Racing Car) - which is not known at this point - and can be added anytime, without the need of changing this code.
                    var deserializationResult = JsonConvert.DeserializeObject<TVehicle>(this.DataJson);
                    return deserializationResult; 
            } 
        }

    }
}