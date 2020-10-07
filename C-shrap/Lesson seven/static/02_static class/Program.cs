using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Club c1 = new Club(); -> Error

            Console.WriteLine(Club.addPerson());
            Console.WriteLine(Club.addPerson());
            Console.WriteLine(Club.addPerson());
            Console.WriteLine(Club.addPerson());

            //Club.NumOfPeople = 34;



            /*
             *  Class people started!
                People in the class: 1
                People in the class: 2
                People in the class: 3
                People in the class: 4

            */


            Console.ReadKey();
        }
    }
}
