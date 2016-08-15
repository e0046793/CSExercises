using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Input travelled distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total fare: ${0}", CalculateFare(distance));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double baseCharge = 2.4;
            return Math.Round(baseCharge + distance * 0.4, 1);

        }
    }
}
