using Microsoft.AspNetCore.Mvc;
using Models;
using Models.VehicleTypes;
using Services;
using Newtonsoft.Json;

namespace aspnet_generics_example1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehiclesService _vehiclesService;
        public VehiclesController(IVehiclesService vehiclesService)
        {
            _vehiclesService = vehiclesService;
        }

        [HttpGet("Ferrari")]
        public async Task<string> GetFerrari()
        {
            var vehicle1_FerrariRaw = new UniversalVehicleData
            {
                DataJson = "{\"Engine\": \"2,936 cc (2.9 L) twin-turbocharged V8\", \"PowerOutput\": \"477HP\",\"Transmission\": \"5-speed manual\", \"Wheelbase\": \"2,450 mm (96.5 in)\",\"Length\": \"4,358 mm (171.6 in)\", \"Width\": \"1,970 mm (77.6 in)\",\"Height\": \"\t1,124 mm (44.3 in)\" }",
                VehicleName = "Ferrari F40",
                RegistrationNumber = "XD66666",
                VehicleType = "Car"
            };


            //var ferrariData = new GenericVehicle<Car>(vehicle1_FerrariRaw).Data;
               
            //var serializedFerrariData = JsonConvert.SerializeObject(ferrariData);
            var ferrariData = _vehiclesService.GetVehicleDetails(vehicle1_FerrariRaw);

            // return serializedFerrariData;

            return ferrariData;
        }


        [HttpGet("Pinarello")]
        public async Task<string> GetPinarello()
        {

            var vehicle2_PinarelloRaw = new UniversalVehicleData
            {
                DataJson = "{ \"Cassette\": \"Sram Red XG-1290\", \"Chain\": \"sram red 12s\", \"FrontDerailleur\": \"SRAM Red ETAP AXS 12S\", \"RearDerailleur\": \"SRAM Red ETAP AXS 12S\", \"BottomBracket\": \"SRAM Red\", \"Frame\": \"TorayCa T1100 1K Dream Carbon with Nanoalloy technology, TiCR™ cable routing, Italian BB, UCI approved\", \"Fork\": \"F Onda Fork with ForkFlap™, 1.5' upper and lower steerer, Ultra Light Headset bearings\", \"WheelsAndTyres\": \"Pirelli P Zero Race 26mm - Black, 127 tpi aramid breaker. Max tyre size 28mm (width as measured)\" }",
                VehicleName = "Pinarello Dogma",
                RegistrationNumber = "P1111111",
                VehicleType = "Road Bicycle"
            };

            var ferrariData = new GenericVehicle<RoadBicycle>(vehicle2_PinarelloRaw).Data;

            var serializedFerrariData = JsonConvert.SerializeObject(ferrariData);

            return serializedFerrariData;
        }



        [HttpGet("Romet")]
        public async Task<string> GetRomet()
        {

            var romet = new UniversalVehicleData
            {
                DataJson = "{ \"Cassette\": \"Sram Red XG-1290\", \"Chain\": \"sram red 12s\", \"FrontDerailleur\": \"SRAM Red ETAP AXS 12S\",  elsAndTyres\": \"Pirelli P Zero Race 26mm - Black, 127 tpi aramid breaker. Max tyre size 28mm (width as measured)\" }",
                VehicleName = "Romet Wigry 3",
                RegistrationNumber = "P1111111",
                VehicleType = "Składak"
            };

            var ferrariData = new GenericVehicle<RoadBicycle>(romet).Data;

            var serializedFerrariData = JsonConvert.SerializeObject(ferrariData);

            return serializedFerrariData;
        }
    }
}