using System;

namespace lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert input from user(string to int32):

            Console.WriteLine("Please enter num1:");
            string num1 = Console.ReadLine();
            int n1 = Convert.ToInt32(num1);

            Console.WriteLine("Please enter num2:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");

            // convert:
            int x = 5;
            double d = Convert.ToDouble(x);
            Console.WriteLine($"x = {x}, d = {d}");

            // try to convert string data to int.
            // will stop the program! error!
            string name = "John";
            int nameUser = Convert.ToInt32(name);

            Console.WriteLine(nameUser);

            Console.ReadKey();
        }
    }
}
