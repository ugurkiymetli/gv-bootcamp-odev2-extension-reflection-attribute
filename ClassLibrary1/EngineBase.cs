using System;

namespace ClassLibrary1
{
    public class EngineBase : IEngine
    {
        public string Make { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating...");
        }
    }
}
