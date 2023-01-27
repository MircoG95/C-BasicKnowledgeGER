using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eindimensionaler Array
            int[] intarr = new int[5];
            string[] strarr = new string[3];

            intarr[0] = 15;
            intarr[1] = 21;
            intarr[2] = 42;
            intarr[3] = 33;
            intarr[4] = 102;

            for (int zaehler = 0; zaehler < intarr.Length; zaehler++)
            {
                Console.WriteLine(intarr[zaehler]);
            }
            Console.WriteLine();

            foreach (int item in intarr)
            {
                Console.WriteLine(item);
            }

            //Mehrdimensionale Arrays
            int[,] intarr2 = new int[3, 2];

            intarr2[0, 0] = 42;
            intarr2[2, 1] = 21;

            int[,,] intarr3 = new int[5, 6, 4];

            int[,,,,,,,,,] intarr4 = new int[1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            intarr4[0, 0, 0, 0, 0, 0, 0, 0, 0, 0] = 112;

            Console.WriteLine(intarr4[0, 0, 0, 0, 0, 0, 0, 0, 0, 0]);
            Console.WriteLine();

            Console.WriteLine(intarr);

        }
    }
}
