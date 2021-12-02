using ClassLibrary1;
using System;

namespace Extensions
{
    public static class Extensions
    {
        public static string GetVehicleMakeModel( this IVehicle vehicle )
        {
            return $"This vehicle is {vehicle.Make} - {vehicle.Model}.";
        }

        public static Type GetObjectType( this IVehicle vehicle )
        {
            return vehicle.GetType();
        }
    }
}
