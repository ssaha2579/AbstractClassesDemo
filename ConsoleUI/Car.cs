using System;
namespace ConsoleUI;

public class Car: Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("This vehicle is driving abstract");
    }
    
    public bool HasTrunk { get; set; }
}

/*
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the derived classes such as HasTrunk for Car 
 * Provide the implementations for the abstract methods
 
 */
