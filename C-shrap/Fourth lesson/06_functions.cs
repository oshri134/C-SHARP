using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // call functions:
            PrintHello(); // Hello students
            sum(65, 3); // 65 + 3 = 68
            Console.WriteLine(BlessUser("Ben")); // hello Ben

            Console.ReadKey();
        }

        // basic function: does not return value, and does not have parameters:
        static void PrintHello()
        {
            Console.WriteLine("Hello students");
        }

        // basic function: does not return value, and does have parameters:
        static void sum(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        // basic function: does return value, and does have parameters:
        static string BlessUser(string user)
        {
            return $"hello {user}";
        }

        /*
         * 1. create a function that get 4 float numbers, and returns the multiplied value. 
         * 2. create a function that gets firstName, lastName and age, and will check:
         *      * age validation (0, and 120). if not valid - return "Age is not valid". 
         *      * if age >= 18 and <=21: print: "you are in the army/ national service"
         *      * if age < 18: print: "you are too young, ", and print the amount of years left to the army. 
         *      * else: print "No duties". 
         */

    }
}
