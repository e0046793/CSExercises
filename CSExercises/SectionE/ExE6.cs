using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can use ExE4.IsPerfectNumber() method here

            Console.WriteLine("Perfect numbers from 1 to 1000");

            for (int counter = 1; counter <= 1000; counter++)
            {
                if (ExE4.IsPerfectNumber(counter))
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
