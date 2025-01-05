using System;
namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine("Motorcycle is driving");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle is still driving!");
    }
}