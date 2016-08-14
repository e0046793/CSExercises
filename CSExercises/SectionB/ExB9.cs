using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Input travelled distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total fare: ${0:#,##0.00}", CalculateFare(distance));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double baseCharge = 2.4;
            double roundedValue = 10.0;
            return Math.Ceiling((baseCharge + distance * 0.4) * roundedValue) / roundedValue;

        }
    }
}
