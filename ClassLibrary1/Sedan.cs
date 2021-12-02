using System;

namespace ClassLibrary1
{
    public class Sedan : VehicleBase, IVehicle
    {

        public Sedan( string make, string model )
        {
            Make = make;
            Model = model;
        }


        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public EngineBase Engine { get; set; }
        public override void Drive()
        {
            Console.WriteLine("Go somewhere by road!");
        }
    }
}