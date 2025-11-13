namespace InterfaceExercise;

public interface IVehicle : ICompany
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }

    void DisplayDetails();
}