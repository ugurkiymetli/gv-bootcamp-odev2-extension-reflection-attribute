using System;

namespace ClassLibrary1
{
    public class SUV : VehicleBase, IVehicle
    {
        public SUV( string make, string model )
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
            //Engine.StartEngine();
            //Engine.Accelerate();
            Console.WriteLine("Go somewhere by offroad!");
        }
    }
}
