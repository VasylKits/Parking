// TODO: implement the ParkingService class from the IParkingService interface.
//       For try to add a vehicle on full parking InvalidOperationException should be thrown.
//       For try to remove vehicle with a negative balance (debt) InvalidOperationException should be thrown.
//       Other validation rules and constructor format went from tests.
//       Other implementation details are up to you, they just have to match the interface requirements
//       and tests, for example, in ParkingServiceTests you can find the necessary constructor format and validation rules.
using System;
using Apache.NMS.ActiveMQ.Commands;
using CoolParking.BL.Interfaces;
using CoolParking.BL.Models;
using System.Collections.ObjectModel;
using System.Linq;

public class ParkingService : IParkingService
{
    Parking parking = Parking.Ititialize();
    public void AddVehicle(Vehicle vehicle) 
    {
        if (Setting.Capacity == 0)
            throw new System.InvalidOperationException();
        parking.Vechicles.Add(vehicle);
        Setting.Capacity -= 1;
    }

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public decimal GetBalance()
    {
        return Setting.Balance;
    }

    public int GetCapacity()
    {
        return parking.Vechicles.Count;
    }

    public int GetFreePlaces()
    {
        return Setting.Capacity;
    }

    public TransactionInfo[] GetLastParkingTransactions()
    {
        throw new System.NotImplementedException();
    }

    public ReadOnlyCollection<Vehicle> GetVehicles()
    {
        var vehicleList = parking.Vechicles;
        ReadOnlyCollection<Vehicle> readOnlyVehicles = new ReadOnlyCollection<Vehicle>(vehicleList);
        if (readOnlyVehicles is null)
            throw new System.NullReferenceException();
        return readOnlyVehicles;
    }

    public string ReadFromLog()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveVehicle(string vehicleId)
    {
        var del = GetVehicles().FirstOrDefault(x => x.Id == vehicleId);
        if (del != null)
        {
            parking.Vechicles.Remove(del);
            Console.WriteLine($"Deleted success {vehicleId}");
        }
        Console.WriteLine($"No car with Id {vehicleId}");
    }

    public void TopUpVehicle(string vehicleId, decimal sum)
    {
        throw new System.NotImplementedException();
    }
}