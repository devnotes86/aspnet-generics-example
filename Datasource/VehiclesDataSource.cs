using Models;

namespace Datasource
{
    public static class VehiclesDataSource
    {

        public static List<UniversalVehicleData> GetVehiclesList()
        {


            var vehicleList = new List<UniversalVehicleData>();
            vehicleList.Add(
                    new UniversalVehicleData
                    {
                        Id = 1,
                        DataJson = "{ \"Cassette\": \"Sram Red XG-1290\", \"Chain\": \"sram red 12s\", \"FrontDerailleur\": \"SRAM Red ETAP AXS 12S\", \"RearDerailleur\": \"SRAM Red ETAP AXS 12S\", \"BottomBracket\": \"SRAM Red\", \"Frame\": \"TorayCa T1100 1K Dream Carbon with Nanoalloy technology, TiCR™ cable routing, Italian BB, UCI approved\", \"Fork\": \"F Onda Fork with ForkFlap™, 1.5' upper and lower steerer, Ultra Light Headset bearings\", \"WheelsAndTyres\": \"Pirelli P Zero Race 26mm - Black, 127 tpi aramid breaker. Max tyre size 28mm (width as measured)\" }",
                        VehicleName = "Pinarello Dogma",
                        RegistrationNumber = "P1111111",
                        VehicleType = VehicleTypes.RoadBike
                    });

            vehicleList.Add(
                  new UniversalVehicleData
                  {
                      Id = 2,
                      DataJson = "{ \"Cassette\": \"Sram Red XG-1290\", \"Chain\": \"sram red 12s\", \"FrontDerailleur\": \"SRAM Red ETAP AXS 12S\", \"RearDerailleur\": \"SRAM Red ETAP AXS 12S\", \"BottomBracket\": \"SRAM Red\", \"Frame\": \"TorayCa T1100 1K Dream Carbon with Nanoalloy technology, TiCR™ cable routing, Italian BB, UCI approved\", \"Fork\": \"F Onda Fork with ForkFlap™, 1.5' upper and lower steerer, Ultra Light Headset bearings\", \"WheelsAndTyres\": \"Pirelli P Zero Race 26mm - Black, 127 tpi aramid breaker. Max tyre size 28mm (width as measured)\" }",
                      VehicleName = "SWORKS Tarmac",
                      RegistrationNumber = "S9394394",
                      VehicleType = VehicleTypes.RoadBike
                  });

            vehicleList.Add(
                  new UniversalVehicleData
                  {
                      Id = 3,
                      DataJson = "{ \"Weight\": \"30kg\", \"Chain\": \"sram red 12s\", \"WheelSize\": \"22in\" }",
                      VehicleName = "Romet Wigry 3",
                      RegistrationNumber = "P1111111",
                      VehicleType = VehicleTypes.FoldingBike
                  });

            vehicleList.Add(
             new UniversalVehicleData
             {
                 Id = 4,
                 DataJson = "{\"Engine\": \"2,936 cc (2.9 L) twin-turbocharged V8\", \"PowerOutput\": \"477HP\",\"Transmission\": \"5-speed manual\", \"Wheelbase\": \"2,450 mm (96.5 in)\",\"Length\": \"4,358 mm (171.6 in)\", \"Width\": \"1,970 mm (77.6 in)\",\"Height\": \"\t1,124 mm (44.3 in)\" }",
                 VehicleName = "Ferrari F40",
                 RegistrationNumber = "XD66666",
                 VehicleType = VehicleTypes.RacingCar
             });



            vehicleList.Add(
             new UniversalVehicleData
             {
                        Id = 5,
                 DataJson = "{\"Engine\": \"6.0L Turbo Diesel V6\", \"PowerOutput\": \"680HP\",\"Transmission\": \"16-speed semi-automatic\", \"Axles\": \"3\", \"MaxLoad\": \"50tons\" }",
                 VehicleName = "Mercedes Actros",
                 RegistrationNumber = "SG755AU",
                 VehicleType = VehicleTypes.Truck
             });


            vehicleList.Add(
             new UniversalVehicleData
             {
                 Id = 6,
                 DataJson = "{\"Engine\": \"5.0L Turbo Diesel V8\", \"PowerOutput\": \"700HP\",\"Transmission\": \"16-speed automatic\", \"Axles\": \"3\", \"Weight\": \"20tons\", \"Weight\": \"55\"  }",
                 VehicleName = "Setra TopClass HDH",
                 RegistrationNumber = "SO888JG",
                 VehicleType = VehicleTypes.Coach
             });

            return vehicleList;
        }

    }
}