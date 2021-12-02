using ConsoleApp1;
using System;

namespace Extensions
{
    public static class Extensions
    {
        public static string GetVehicleMakeModel( this Vehicle vehicle )
        {
            return $"This vehicle is {vehicle.Make} - {vehicle.Model}.";
        }

        public static Object GetObjectType( this Vehicle type )
        {
            return type.GetType();
        }
    }
}
