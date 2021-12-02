using System;

namespace ClassLibrary1
{
    public class DieselEngine : IEngine
    {
        public string Make { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Diesel engine started!");
        }
    }
}
