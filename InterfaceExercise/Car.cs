using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public string CorporateFounder { get; set; }
    public string Headquarters { get; set; }
    public bool StickShift { get; set; }
    public string FuelOctaneGrade { get; set; } // "regular", "mid-grade", "premium"

    public void DisplayDetails_IVehicle()
    {
        Console.WriteLine($"{Year} {Make} {Model}\nEngine: {Engine}\nStick Shift: {StickShift}\nFuel Grade: {FuelOctaneGrade}");
    }

    public void DisplayDetails_ICompany()
    {
        Console.WriteLine($"Founder: {CorporateFounder}\nHeadquarters: {Headquarters}");
    }
}