using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public string CorporateFounder { get; set; }
    public string Headquarters { get; set; }
    public bool Armored { get; set; }
    public string Terrain { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Make} {Model}\nEngine: {Engine}\nFounder: {CorporateFounder}\nHeadquarters: {Headquarters}\nArmored: {Armored}\nTerrain: {Terrain}");
    }
}