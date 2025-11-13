namespace InterfaceExercise;

public interface ICompany
{
    public string CorporateFounder { get; set; }
    public string Headquarters { get; set; }
    
    void DisplayDetails_ICompany();
}