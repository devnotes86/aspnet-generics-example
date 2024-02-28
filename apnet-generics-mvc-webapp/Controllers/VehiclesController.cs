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


                // The Controller and the Datasource does not know anything about the Vehicle Type (it only knows the name of the type [VehicleType])
                // Having the name of the type and assuming that it's matching the existing View file - the UniversalVehicleData object will be passed to a view.
                // Then inside the view that matches the VehicleType name - a GenericVehicle class will be initialized - and Generic field "Data" will be deserialized based on the class injected in this view.
                // It means that the View is the only place, where the appropriate Type of Vehicle (ex. Models.Coach, Models.RacingCar) needs to be referenced.
                // So there is no need to add any if/switch logic, importing types, adding additional services to manage it etc.
                // Just having the ability to declare a generic type - that is injected in the last stage of rendering - is enough.
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