using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can call ExE3.IsPrime method (from previous exercise) 
            //to check whether a number is a prime or not.

            Console.WriteLine("Prime numbers from 5 to 10000");

            for (int counter = 5; counter <= 10000; counter++)
            {
                if (ExE3.IsPrime(counter))
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
