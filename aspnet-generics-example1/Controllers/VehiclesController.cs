using Microsoft.AspNetCore.Mvc;
using Models;
using Models.VehicleTypeDefinitions;
using Services;
using Newtonsoft.Json;

namespace aspnet_generics_example1.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IVehiclesService _vehiclesService;
        public VehiclesController(IVehiclesService vehiclesService)
        {
            _vehiclesService = vehiclesService;
        }

        //[HttpGet("AllVehicles")]
        //public async Task<string> GetAllVehicles()
        //{
          



        //    var carData = new GenericVehicle<RoadBicycle>(carUniversalData).Data;

        //    var serializedCarData = JsonConvert.SerializeObject(carData);

        //    return serializedCarData;
        //}

        [HttpGet("Ferrari")]
        public async Task<IActionResult> GetFerrari()
        {
            var list = Datasource.VehiclesDataSource.GetVehiclesList();

            var ferrari = list.FirstOrDefault(x => x.VehicleType == VehicleTypes.RacingCar);

            var carData = _vehiclesService.GetVehicleDetails(ferrari);

            var serializedCarData = JsonConvert.SerializeObject(carData);

            return View("RacingCar", carData);
        }


        [HttpGet("Pinarello")]
        public async Task<string> GetPinarello()
        {

            var bikeUniversalData = new UniversalVehicleData
            {
                DataJson = "{ \"Cassette\": \"Sram Red XG-1290\", \"Chain\": \"sram red 12s\", \"FrontDerailleur\": \"SRAM Red ETAP AXS 12S\", \"RearDerailleur\": \"SRAM Red ETAP AXS 12S\", \"BottomBracket\": \"SRAM Red\", \"Frame\": \"TorayCa T1100 1K Dream Carbon with Nanoalloy technology, TiCR™ cable routing, Italian BB, UCI approved\", \"Fork\": \"F Onda Fork with ForkFlap™, 1.5' upper and lower steerer, Ultra Light Headset bearings\", \"WheelsAndTyres\": \"Pirelli P Zero Race 26mm - Black, 127 tpi aramid breaker. Max tyre size 28mm (width as measured)\" }",
                VehicleName = "Pinarello Dogma",
                RegistrationNumber = "P1111111",
                VehicleType = VehicleTypes.RoadBike
            };

            var bikeData = new GenericVehicle<RoadBicycle>(bikeUniversalData).Data;

            var serializedBikeData = JsonConvert.SerializeObject(bikeData);

            return serializedBikeData;
        }



        [HttpGet("Romet")]
        public async Task<string> GetRomet()
        {

            var bikeUniversalData = new UniversalVehicleData
            {
                DataJson = "{ \"Cassette\": \"Sram Red XG-1290\", \"Chain\": \"sram red 12s\", \"FrontDerailleur\": \"SRAM Red ETAP AXS 12S\",  elsAndTyres\": \"Pirelli P Zero Race 26mm - Black, 127 tpi aramid breaker. Max tyre size 28mm (width as measured)\" }",
                VehicleName = "Romet Wigry 3",
                RegistrationNumber = "P1111111",
                VehicleType = VehicleTypes.FoldingBike
            };

            var bikeData = new GenericVehicle<RoadBicycle>(bikeUniversalData).Data;

            var serializedBikeData = JsonConvert.SerializeObject(bikeData);

            return serializedBikeData;
        }
    }
}