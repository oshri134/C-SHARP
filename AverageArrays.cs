using System;


namespace AverageArrays
{
    class Program
    {
        static void Main(string[] args)
        {



            double[] scoresOne = new double[5] { 45.3, 45, 43, 12.4, 45 };
            double[] scoresTwo = new double[5] { 45.4, 90.4, 60, 70, 12 };

            double arrOne = avgBigger(scoresOne);
            double arrTwo= avgBigger(scoresTwo);

            if (arrOne > arrTwo)
            {

                Console.WriteLine("The first scores are larger");
            }
            else
            {
                Console.WriteLine("The second scores are larger");
            }

        }
        public static double avgBigger(double[] arr)
        {

            double resulte;

            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = +arr[i];

            }
            resulte = sum / arr.Length;

            return resulte;


        }

    }

}

