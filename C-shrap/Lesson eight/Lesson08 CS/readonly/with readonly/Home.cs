using System;

namespace Lesson08
{
    class Home
    {
        // Proeprties:
        // in regular variable: can be assigned to only in constructor, or initialization line. 
        public readonly int NumOfRooms = 4;

        // in static variable: can be assigned to only in static constructor, or initialization line. 
        public static readonly string Country = "Israel";

        // ctor:
        public Home(int numOfRooms)
        {
            NumOfRooms = numOfRooms;
        }

        // ToString:
        public override string ToString()
        {
            return $"Home from {Country}, has: {NumOfRooms} rooms";
        }

    }
}
