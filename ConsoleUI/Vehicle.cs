namespace ConsoleUI;

public abstract class Vehicle
{
    public int Year { get; set; } = 2024;
    public string Make { get; set; } = "Make";
    public string Model { get; set; } = "Model";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        
    }
}