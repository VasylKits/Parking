// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Create IParkingServece's object");

var services = new ParkingService();

var bmw = new Vehicle(VehicleType.PassengerCar, 250);
var reno = new Vehicle(VehicleType.Truck, 1000);
var bike = new Vehicle(VehicleType.Motorcycle, 100);
var bogdan = new Vehicle(VehicleType.Bus, 2000);

services.AddVehicle(bogdan);
services.AddVehicle(bmw);
services.AddVehicle(reno);
services.AddVehicle(bike);

Console.WriteLine("// - // - // - // - // - //");


Console.WriteLine("// - // - // - // - // - //");