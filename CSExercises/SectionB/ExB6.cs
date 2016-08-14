using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double x1, x2, y1, y2;

            Console.Write("Input x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Distance is: {0}", CalculateDistance(x1, y1, x2, y2));
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
    }
}
