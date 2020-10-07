using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson07
{
    static class Club
    {
        // no instances, all must be static

        // Properties:
        private static int numOfPeople;
        public static int NumOfPeople
        {
            get { return numOfPeople; }
            set {
                if(value <= 100)
                numOfPeople = value; 
            }
        }

        // ctor:
        static Club()
        {
            Console.WriteLine("Class people started!");
        }

        // Methods
        public static string addPerson()
        {
            numOfPeople++;
            return $"People in the class: {numOfPeople}";
        }
    }
}
