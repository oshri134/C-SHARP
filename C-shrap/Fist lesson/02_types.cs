using System;

namespace lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- numbers: ------------------------
            // byte:
            byte byte1 = 4;
            Console.WriteLine(byte1);

            // sbyte: 
            sbyte sbyte1 = -7;
            Console.WriteLine(sbyte1);

            // int : int32 is the default. 4 * 8 = 32
            int int1 = 65;

            // uint: unsingned int. (only positive)
            uint uint1 = 56;

            // long : 8 byte
            long long1 = 5435;

            // ulong 8 byte. only positive:
            ulong ulong1 = 654;


            // float 4 byte:
            float float1 = 67.8f;

            // double 8 byte:
            double double1 = 45.6754;

            // decimal 16 byte:
            decimal decimal1 = 2423.754754m;

            // ---------------- boolean: ------------------------
            bool b1 = true;
            b1 = false;

            // ---------------- char: ------------------------
            // char takes 2 byte in memory. 
            char c1 = 'h';


            // ---------------- string: ------------------------
            // reference typed. 
            string str = "hello 6789gj!";

            Console.ReadKey();

        }
    }
}
