// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

Console.WriteLine("// - // - // - // - // -");

Parking parking = Parking.Ititialize();

var reno = new Vehicle("AB2-5687-VC", VehicleType.PassengerCar, 100);
Console.WriteLine(reno.Id + " " + reno.VehicleType + " " + reno.Balance);

var daf = new Vehicle("D1-2658-DC", VehicleType.Truck, 200);

Console.WriteLine("// - // - // - // - // - //");

public class Vehicle
{
    [RegularExpression(@"^[A-Z]-\d{4}-[A-Z]+$")]
    public string Id { get; init; }
    public VehicleType VehicleType { get; init; }
    public decimal Balance { get; set; }
    public Vehicle(string id, VehicleType vehicleType, decimal balance)
    {
        Id = id;
        VehicleType = vehicleType;
        Balance = balance;
    }  
}
public class Parking
{
    private static Parking parking;
    protected Parking()
    {

    }
    public static Parking Ititialize()
    {
        if (parking == null)
            parking = new Parking();

        return parking;
    }
    private decimal balance;
    public decimal Balance 
    {
        get { return balance; }
        set { balance = value; }
    }
    private List<Vehicle> vehicles;
    public List<Vehicle> Vechicles 
    {
        get { return vehicles; }
        set { vehicles = value; } 
    }
}
public enum VehicleType
{
    PassengerCar,
    Truck,
    Bus,
    Motorcycle
}

