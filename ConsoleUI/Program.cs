using System;
using System.Collections.Generic;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!!
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             var vech


             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /*
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
             */

            // Create a list of Vehicle called vehicles
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *
             * Set the properties values with object initializer syntax
             */

            var carOne = new Car()
            {
                Year = "2025",
                Make = "Toyota",
                Model = "Camry",
                HasTrunk = true
            };

            var motorcycleOne = new Motorcycle()
            {
                Year = "2020",
                Make = "Suzuki",
                Model = "GSX-R600",
                HasSideCart = true
            };

            Vehicle carTwo = new Car()
            {
                Year = "2005",
                Make = "Ford",
                Model = "Mustang",
                HasTrunk = true
            };

            var motorcycleTwo = new Motorcycle()
            {
                Year = "2022",
                Make = "Harley-Davidson",
                Model = "Road Glide",
                HasSideCart = true
            };

            var vehicles = new List<Vehicle>() { carOne, motorcycleOne, carTwo, motorcycleTwo };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make},  {vehicle.Model}");
            }

            carOne.DriveAbstract();
            carTwo.DriveAbstract();
            motorcycleTwo.DriveAbstract();
            motorcycleOne.DriveAbstract();
            
            Console.ReadLine();
        }
    }
                
            

            // Call each of the drive methods for one car and one motorcycle
            #endregion            
        }
    

