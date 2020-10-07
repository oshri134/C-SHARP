using System;

namespace Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of class `Food`:
            Food f1 = new Food();
            f1.FoodName = "Apple";
            f1.ExpirationDate = new ExDate(23, 1, 2034);

            Console.WriteLine(f1); // food name: Apple
            Console.WriteLine(f1.FoodName); // Apple

            // note: if we call an object - it goes to thew ToString() method: 
            Console.WriteLine(f1.ExpirationDate.ToString()); // Date: 23 / 1 / 2034
            Console.WriteLine(f1.ExpirationDate); // Date: 23 / 1 / 2034


            Console.ReadKey();
        }
    }
}
