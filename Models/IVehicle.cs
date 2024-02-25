namespace Models
{
    public interface IVehicle //<TVehicle>
    {
        //TVehicle Data { get; }
        string DataJson { get; set; }
        string RegistrationNumber { get; set; }
        string VehicleName { get; set; }
        string VehicleType { get; set; }
    }
}