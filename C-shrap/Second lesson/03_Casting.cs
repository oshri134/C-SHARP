using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // define variables:

            byte byte1 = 4;   // 1 byte 
            int int1 = 4;     // 4 byte 
            long long1 = 4;   // 8 byte 

            // casting - convert from one type to another: 

            // implicit conversion: המרה מרומזת
            // will happen when there is no data loss. from small number to big number. 

            int1 = byte1;
            long1 = byte1;
            long1 = int1;

            // explicit conversion - המרה מפורשת
            // will happen when we can lose data. from big number to small number. 

            byte1 = (byte)int1;
            byte1 = (byte)long1;
            int1 = (int)long1;


            Console.ReadKey();
        }
    }
}
