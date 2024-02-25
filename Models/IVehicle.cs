namespace Models
{
    public interface IVehicle  
    { 
        string DataJson { get; set; }
        string RegistrationNumber { get; set; }
        string VehicleName { get; set; }
        string VehicleType { get; set; }
    }
}