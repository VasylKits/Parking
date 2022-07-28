// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

Console.WriteLine("Create IParkingServece's object");

var services = new ParkingService();

Console.WriteLine($"Capacity = {services.GetCapacity()}");

var bmw = new Vehicle(VehicleType.PassengerCar, 250, "AA-0001-AA");
var reno = new Vehicle(VehicleType.Truck, 1000, "AA-0002-AA");
var bike = new Vehicle(VehicleType.Motorcycle, 100, "AA-0003-AA");
var bogdan = new Vehicle(VehicleType.Bus, 2000, "AA-0004-AA");

services.AddVehicle(bogdan);
services.AddVehicle(bmw);
services.AddVehicle(reno);
services.AddVehicle(bike);

Console.WriteLine($"bike balance = {bike.Balance}");
services.RemoveVehicle("AA-0005-AA");


Console.WriteLine("// - // - // - // - // - //");

foreach (var vehicle in services.GetVehicles())
{
    Console.WriteLine($"{vehicle.Id} {vehicle.VehicleType} { vehicle.Balance}");
}

Console.WriteLine($"Capacity = {services.GetCapacity()}");
Console.WriteLine($"Free Places = {services.GetFreePlaces()}");

Console.WriteLine();
services.RemoveVehicle("AA-0003-AA");
Console.WriteLine($"Capacity = {services.GetCapacity()}");
Console.WriteLine($"Free Places = {services.GetFreePlaces()}");
Console.WriteLine("// - // - // - // - // - //");

foreach (var vehicle in services.GetVehicles())
{
    Console.WriteLine($"{vehicle.Id} {vehicle.VehicleType} {vehicle.Balance}");
}

services.RemoveVehicle("AA-0001-AA");
foreach (var vehicle in services.GetVehicles())
{
    Console.WriteLine($"{vehicle.Id} {vehicle.VehicleType} {vehicle.Balance}");
}

services.TopUpVehicle("AA-0004-AA", 200);
services.AddVehicle(bike);
services.AddVehicle(bmw);
foreach (var vehicle in services.GetVehicles())
{
    Console.WriteLine($"{vehicle.Id} {vehicle.VehicleType} {vehicle.Balance}");
}
Console.WriteLine($"Capacity = {services.GetCapacity()}");
Console.WriteLine($"Free Places = {services.GetFreePlaces()}");