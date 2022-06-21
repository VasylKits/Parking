// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Create IParkingServece's object");

var services = new ParkingService();

Console.WriteLine($"Capacity = {services.GetCapacity()}");

var bmw = new Vehicle(VehicleType.PassengerCar, 250);
var reno = new Vehicle(VehicleType.Truck, 1000);
var bike = new Vehicle(VehicleType.Motorcycle, 100);
var bogdan = new Vehicle(VehicleType.Bus, 2000);
var bmw1 = new Vehicle(VehicleType.PassengerCar, 250);
var reno1 = new Vehicle(VehicleType.Truck, 1000);
var bike1 = new Vehicle(VehicleType.Motorcycle, 100);
var bogdan1 = new Vehicle(VehicleType.Bus, 2000);
var bmw2 = new Vehicle(VehicleType.PassengerCar, 250);
var reno2 = new Vehicle(VehicleType.Truck, 1000);

services.AddVehicle(bogdan);
services.AddVehicle(bmw);
services.AddVehicle(reno);
services.AddVehicle(bike);
services.AddVehicle(bogdan1);
services.AddVehicle(bmw1);
services.AddVehicle(reno1);
services.AddVehicle(bike1);
services.AddVehicle(bmw2);
//services.AddVehicle(reno2);

Console.WriteLine("// - // - // - // - // - //");

foreach (var vehicle in services.GetVehicles())
{
    Console.WriteLine($"{vehicle.Id} {vehicle.VehicleType} { vehicle.Balance}");
}

Console.WriteLine($"Capacity = {services.GetCapacity()}");
Console.WriteLine($"Free Places = {services.GetFreePlaces()}");

services.RemoveVehicle("AA-3344-JH");
Console.WriteLine("// - // - // - // - // - //");