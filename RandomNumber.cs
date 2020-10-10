using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = randomArr(5);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
        }

        static int[] randomArr(int arrSize)
        {

            int[] result = new int[arrSize];
            Random random = new Random();
            for (int i = 0; i < arrSize; i++)
            {
             
                int radomNum = random.Next(100);

                result[i] = radomNum;
            }
            return result;
        }

      
    }
}
