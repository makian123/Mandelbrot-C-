using System;
using System.Numerics;

namespace Mandelbrot_set
{
    class Program
    {
        static void Main(string[] args)
        {
            double xPos;
            double yPos;
            int iterations;
            bool debugMode = true;

            Console.Write("Enter the x position: ");
            xPos = double.Parse(Console.ReadLine());
            Console.Write("Enter the y position: ");
            yPos = double.Parse(Console.ReadLine());
            Console.Write("Enter max iterations: ");
            iterations = int.Parse(Console.ReadLine());

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
