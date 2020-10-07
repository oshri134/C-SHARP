using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            Console.WriteLine("\n------ while --------");
            int counter = 3;
            while(counter > 0)
            {
                Console.Write($"{counter} ");
                counter--;
            }
            // output: 3 2 1



            // do - while
            Console.WriteLine("\n------ do while --------");
            counter = 3;
            do
            {
                Console.Write($"{counter} ");
                counter--;
            } while (counter > 0);
            // output: 3 2 1


            // for
            Console.WriteLine("\n------ for --------");
            
            for (counter = 3; counter > 0; counter--)
            {
                Console.Write($"{counter} ");
            }
            // output: 3 2 1

            Console.ReadKey();
        }
    }
}
