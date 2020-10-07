using System;

namespace Lesson08
{
    class Home
    {
        // Proeprties:
        public int NumOfRooms = 4;

        public static string Country = "Israel";

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
