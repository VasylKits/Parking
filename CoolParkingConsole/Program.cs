// See https://aka.ms/new-console-template for more information
using CoolParking.BL.Models;

Console.WriteLine("// - // - // - // - // -");

//Parking parking = Parking.Ititialize();

var reno = new Vehicle("AB2-5687-VC", VehicleType.PassengerCar, 100);
Console.WriteLine(reno.Id + " " + reno.VehicleType + " " + reno.Balance);

ParkingServices services = new ParkingServices();
services.AddVehicle(reno);

Console.WriteLine(services.GetCapacity());



Console.WriteLine("// - // - // - // - // - //");