using apnet_generics_mvc_webapp.Models;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.VehicleTypeDefinitions;
using Models.ViewModels;
using Newtonsoft.Json; 
using System.Diagnostics;

namespace apnet_generics_mvc_webapp.Controllers
{
    [Route("Vehicles")]
    public class VehiclesController : Controller
    { 
        public VehiclesController( )
        {
          
        }
         
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> VehicleDetails(string id)
        {
            var vehicle = Datasource.VehiclesDataSource.GetVehiclesList().Find(x => x.Id.ToString() == id);

            if (vehicle == null) {
                return View("NotFound");
            } 
            else
            {
                var viewName = vehicle.VehicleType.ToString();

                return View(viewName, vehicle);
            } 
        }
         
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        { 
            VehiclesIndex vehicles = new VehiclesIndex
            {
                Vehicles = Datasource.VehiclesDataSource.GetVehiclesList()
            };

            return View("Index", vehicles);
        } 
    }
}