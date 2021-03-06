﻿using System;

namespace CSExercises
{
    public class ExE3
    {
        //Given an integer as input determine whether the number 
        //is a prime number or not.  Your program should output “Prime” 
        //    or “Not Prime” as the case may be.

        //A Prime Number is one which is only divisible by one and itself.

        //Consider how the efficiency of the program can be improved. 
        //Normally the order of complexity is proportional to the number of 
        //    times a loop is executed.A more formal definition of 
        //    “Analysis of Algorithms” will be dealt in a later course.

        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


            if (IsPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }

        public static bool IsPrime(int n)
        {
            //YOUR CODE HERE
            if (1 == n) return false;
            if (0 == n % 2) return false;
            if (0 == n % 3) return false;
            if (2 == n || 3 == n) return true;

            int boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 2; i <= boundary; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
