using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public string CorporateFounder { get; set; }
    public string Headquarters { get; set; }
    public string Fuel { get; set; } // "Petrol", "Diesel"
    public bool Wrecker { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Make} {Model}\nEngine: {Engine}\nFounder: {CorporateFounder}\nHeadquarters: {Headquarters}\nFuel: {Fuel}\nWrecker: {Wrecker}");
    }
}