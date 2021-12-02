using System;

namespace ConsoleApp1
{
    public abstract class Vehicle
    {
        protected Vehicle( string make, string model )
        {
            Make = make;
            Model = model;
        }

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public virtual void GoSomewhere()
        {
            Console.Write("Going somewhere by ");
        }

    }
}