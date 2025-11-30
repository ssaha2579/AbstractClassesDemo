using System; 
namespace ConsoleUI;

public class Motorcycle: Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("This motorcycle is driving abstract");
    }
    
    public bool HasSideCart {get; set;}

    public override void DriveVirtual()
    {
        Console.WriteLine("This motorcycle is driving virtual!");
    }
}

/*
 * Now create a non-abstract class  Motorcycle, that inherit from Vehicle
 * Add a distinct property in the derived classes  HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
 */
