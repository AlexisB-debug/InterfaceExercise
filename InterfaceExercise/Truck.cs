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
    
    public void DisplayDetails_IVehicle()
    {
        Console.WriteLine($"{Year} {Make} {Model}\nEngine: {Engine}\nFuel: {Fuel}\nWrecker: {Wrecker}");
    }
    
    public void DisplayDetails_ICompany()
    {
        Console.WriteLine($"Founder: {CorporateFounder}\nHeadquarters: {Headquarters}");
    }
}