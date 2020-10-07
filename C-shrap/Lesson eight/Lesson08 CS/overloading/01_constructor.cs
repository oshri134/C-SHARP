using System;

namespace Lesson08
{
    class Home
    {
        // properties:
        private int numOfRooms;
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set { numOfRooms = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // overloading - we can create more than 1 constructor - but parameters must be diffrent:
        public Home(){} // empty ctor. 

        public Home(int numOfRooms)
        {
            NumOfRooms = numOfRooms;
        }

        public Home(int numOfRooms, string address)
        {
            Address = address;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Home h1 = new Home();
            Home h2 = new Home(6);
            Home h3 = new Home(6, "Jerusalem");
            Console.ReadKey();
        }
    }
}