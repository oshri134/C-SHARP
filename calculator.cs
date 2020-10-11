using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 6;
            int choose;
            do
            {
                choose = menu();

                switch (choose)
                {
                    case 1:
                        {
                            plus();
                            break;
                        }
                    case 2:
                        {
                            MinusNumber();
                            break;
                        }

                    case 3:
                        {
                            Square();
                            break;
                        }
                    case 4:
                        {
                            multiplied();
                            break;

                        }

                    case 5:
                        {
                            showAll();
                            break;

                        }
                }
            } while (choose != exit);
        }
    

            
        public static int menu()
        {

            Console.WriteLine("----------------------");
            Console.WriteLine("       Calculator     ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1) Pluse Number");
            Console.WriteLine("2) Minus Number");
            Console.WriteLine("3) Square");
            Console.WriteLine("4) Multipler");
            Console.WriteLine("5) Show all the number from 1 to 100 Divide By number");
            Console.WriteLine("6) exit");

            Console.WriteLine("Choose your choice");
           int Choose = int.Parse(Console.ReadLine());


            return Choose;

        }
        public static void NoMenu()
        {

            Console.WriteLine("----------------------");
            Console.WriteLine("       Calculator     ");
            Console.WriteLine("----------------------");
            Console.WriteLine("1) Pluse Number");
            Console.WriteLine("2) Pluse Number");
            Console.WriteLine("3) Square");
            Console.WriteLine("4) Multipler");
            Console.WriteLine("5) Show all the number from 1 to 100 Divide By number");
         

        }

        public static void plus()
        {
            int num2, num1 = 0;
            int sum;
            Console.WriteLine("----------------------");
            Console.WriteLine("       Plus Number    ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Insenrt first number:");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert secont number");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Your Result:"+sum);
           


        }

        public static void MinusNumber()
        {
            int num2, num1 = 0;
            int sum;
            Console.WriteLine("----------------------");
            Console.WriteLine("       Minus number    ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Insenrt first number:");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert secont number");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 - num2;
            Console.WriteLine("Your Result:" + sum);



        }

        public static void Square()
        {
            int  num1 = 0;
    
            Console.WriteLine("----------------------");
            Console.WriteLine("       Square number    ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Insenrt first number:");

            num1 = int.Parse(Console.ReadLine());

            double sum =  Math.Sqrt(num1);
            Console.WriteLine("Your Result:" + sum);



        }

        public static void multiplied()
        {
            int num2, num1 = 0;
            int sum;
            Console.WriteLine("----------------------");
            Console.WriteLine("       Multiplied Number    ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Insenrt first number:");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert secont number");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 * num2;
            Console.WriteLine("Your Result:" + sum);



        }

        public static void showAll()
        {
            int num1 = 0;

            Console.WriteLine("----------------------");
            Console.WriteLine("      Show all numbers    ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Insenrt first number:");
            
            do
            {
                Console.WriteLine("The number must be berween 1-100 please try agian");
                num1 = int.Parse(Console.ReadLine());

            } while (!(num1 >= 1 && num1 <= 100));

            Console.WriteLine("The number must be berween 1-100");

            for (int i = 1; i <= 100; i++)
            {
                if (i % num1 == 0)
                {
                    Console.WriteLine(i + ",");

                }
            }
        }
    }
}


