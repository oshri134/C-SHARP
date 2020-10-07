using System;

namespace Lesson08
{
    class Data
    {
        // gets one parameter: string
        public void printData(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        // gets two parameters: string, int
        public void printData(string name, int age)
        {
            Console.WriteLine($"Welcome {name}, your age is: {age}");
        }

        // gets two parameters: string, boolean
        public void printData(string name, bool isIsraeli)
        {
            Console.WriteLine($"Welcome {name}, You are from israel? {isIsraeli}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Data d1 = new Data();
            d1.printData("John"); // Welcome John
            d1.printData("John", true); // Welcome John, You are from israel? True
            d1.printData("John", 34); // Welcome John, your age is: 34
            Console.ReadKey();
        }
    }
}