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



            Random random = new Random();

            int radomNum = random.Next(1,10);
            int num = 0;
            do
            {
                Console.WriteLine("Please enter a number:");
                num = int.Parse(Console.ReadLine());

                if(num== radomNum)
                {
                 
                    Console.WriteLine("You were right"+radomNum);
                 
                }
                else if(num< radomNum)
                {

                    Console.WriteLine("The number is too small");
                }
                else if (num > radomNum){

                    Console.WriteLine("The number is too big");
                }
                
            }
            while (num!=radomNum);

            Console.WriteLine("Please enter to continue");



        }

        
    }
    }

