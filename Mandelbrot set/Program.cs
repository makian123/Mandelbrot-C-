using System;
using System.Numerics;

namespace Mandelbrot_set
{
    class Program
    {
        static void Main(string[] args)
        {
            double xPos = 1;
            double yPos = 0;
            int iterations = 1000;

            double[] point = new double[2] { xPos, yPos };
            Console.WriteLine(belongsToSet(point, iterations)); //Returns true if number is in set, false if not
        }

        static bool belongsToSet(double[] z, int iterations)
        {
            while(iterations > 0)
            {
                if(Math.Abs(z[0]) > 2 || Math.Abs(z[1]) > 2)    //Check if number goes over the limit
                {
                    return false;
                }
                z = square(z);  //Square the number
                --iterations;
            }

            return true;
        }

        private static double[] square(double[] z)
        {
            double rResult, iResult;    //Real and imaginary numbers
            rResult = z[0] * z[0] - z[1] * z[1];    //Calculates the real number
            iResult = 2 * z[1] * z[1];  //Calculates the imaginary

            return new double[2] {rResult, iResult};    //Returns the real and imaginary numbers
        }
    }
}
