using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UniversalVehicleData
    {

        public int Id { get; set; }
        public string DataJson { get; set; }

        public string VehicleName { get; set; }

        public string RegistrationNumber { get; set; }

        public VehicleTypes VehicleType { get; set; }
       

    }
}
