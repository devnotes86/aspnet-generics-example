using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.VehicleTypeDefinitions
{
    public class Coach
    {
        public string Engine { get; set; }
        public string PowerOutput { get; set; }
        public string Transmission { get; set; }
        public string Axles { get; set; }
        public string Weight { get; set; }
        public string MaxPassengers { get; set; }
    }
}
