// TODO: implement class Parking.
//       Implementation details are up to you, they just have to meet the requirements 
//       of the home task and be consistent with other classes and tests.
using System.Collections.Generic;

namespace CoolParking.BL.Models;

public class Parking
{
    private static Parking parking = null;
    protected Parking()
    {

    }
    public static Parking Ititialize()
    {
        if (parking == null)
            parking = new Parking();
        parking.Balance = Setting.Balance;
        parking.Capacity = Setting.Capacity;
        parking.Vechicles = new List<Vehicle>();

        return parking;
    }
    public decimal Balance { get; set; }
    public List<Vehicle> Vechicles { get; set; }
    public int Capacity { get; set; }
}