using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance(מופע) of class `Fruit`
            Fruit f1 = new Fruit();
            f1.name = "Banana";
            f1.price = 5.9m;

            Fruit f2 = new Fruit();
            f2.name = "Apple";
            f2.price = 4.2m;


            Console.ReadKey();
        }
    }

    // a class - does not take place in memory!
    class Fruit
    {
        // properties:
        public string name;

        public decimal price; 
    }
}
