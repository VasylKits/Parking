// TODO: implement the ParkingService class from the IParkingService interface.
//       For try to add a vehicle on full parking InvalidOperationException should be thrown.
//       For try to remove vehicle with a negative balance (debt) InvalidOperationException should be thrown.
//       Other validation rules and constructor format went from tests.
//       Other implementation details are up to you, they just have to match the interface requirements
//       and tests, for example, in ParkingServiceTests you can find the necessary constructor format and validation rules.
using Apache.NMS.ActiveMQ.Commands;
using CoolParking.BL.Interfaces;
using CoolParking.BL.Models;
using System.Collections.ObjectModel;
using System;
using System.Linq;

public class ParkingServices : IParkingService
{
    Parking parking = Parking.Ititialize();
    public void AddVehicle(Vehicle vehicle)
    {
        parking.Vechicles.Add(vehicle);
    }

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public decimal GetBalance()
    {
        throw new System.NotImplementedException();
    }

    public int GetCapacity()
    {
        return Setting.Capacity - parking.Vechicles.Count;
    }

    public int GetFreePlaces()
    {
        throw new System.NotImplementedException();
    }

    public TransactionInfo[] GetLastParkingTransactions()
    {
        throw new System.NotImplementedException();
    }

    public ReadOnlyCollection<Vehicle> GetVehicles()
    {
        var vehicleList = parking.Vechicles.ToList();
            throw new System.NotImplementedException();

    }

    public string ReadFromLog()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveVehicle(string vehicleId)
    {
        throw new System.NotImplementedException();
    }

    public void TopUpVehicle(string vehicleId, decimal sum)
    {
        throw new System.NotImplementedException();
    }
}