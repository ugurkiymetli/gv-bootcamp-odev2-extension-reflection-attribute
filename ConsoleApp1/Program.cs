using ClassLibrary1;
using Extensions;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Sedan sedan = new("Toyota", "Corolla");
            SUV suv = new("Jeep", "Cherokee");
            //Sedan sedan = new("Toyota", "Corolla");
            //SUV suv = new("Jeep", "Cherokee");
            sedan.Drive();

            //extension
            Console.WriteLine(sedan.GetVehicleMakeModel());
            //extension using reflection
            Console.WriteLine($"Typeof object(sedan) is {sedan.GetObjectType()}");

            suv.Drive();
            //extension
            Console.WriteLine(suv.GetVehicleMakeModel());
            //extension using reflection
            Console.WriteLine($"Typeof object(suv) is {suv.GetObjectType()}");
        }
    }
}
