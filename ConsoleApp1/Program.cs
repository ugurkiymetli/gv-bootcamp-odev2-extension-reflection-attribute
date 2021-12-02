using Extensions;
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Sedan sedan = new("Toyota", "Corolla");
            sedan.GoSomewhere();
            //extension
            Console.WriteLine(sedan.GetVehicleMakeModel());
            //extension using reflection
            Console.WriteLine(sedan.GetObjectType());

            SUV suv = new("Jeep", "Cherokee");
            suv.GoSomewhere();
            //extension
            Console.WriteLine(suv.GetVehicleMakeModel());
            //extension using reflection
            Console.WriteLine(suv.GetObjectType());
        }
    }
}
