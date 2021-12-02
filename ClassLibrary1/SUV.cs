using System;

namespace ConsoleApp1
{
    public class SUV : Vehicle
    {
        public SUV( string make, string model ) : base(make, model)
        {
        }
        //abstract oluşturduğumuz methodumuzu burda eziyoruz
        public override void GoSomewhere()
        {
            base.GoSomewhere();
            Console.Write("offroad.");
        }
    }
}