using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input a number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square roof of {0} is {1:0.###}", input, SQRT(input));
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            return Math.Sqrt(x);
        }
    }
}
