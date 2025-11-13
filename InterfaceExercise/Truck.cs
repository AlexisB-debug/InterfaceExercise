namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public string CorporateFounder { get; set; }
    public string Headquarters { get; set; }
    public string Fuel { get; set; } // "Gasoline", "Diesel"
    public bool Wrecker { get; set; }
}