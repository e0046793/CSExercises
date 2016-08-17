using System;

namespace CSExercises
{
    //Given a number find out its factorial.  

    //Write two different C# program variations for 
    //the problem:
    //a.Using increment counter
    //b.Using a decrement counter.

    //Carefully study the similarities and differences 
    //between the two approaches.
    //List the conditions, if any, under which your program 
    //is likely to fail

    public class ExE1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact1 = CalculateFactorialInc(n);
            Console.WriteLine("Increase loop - {0}", fact1);

            int fact2 = CalculateFactorialDec(n);
            Console.WriteLine("Decrease loop - {0}", fact2);

            int fact3 = CalculateFactorialRecursive(n);
            Console.WriteLine("Recursive loopback - {0}", fact3);
        }

        public static int CalculateFactorialInc(int n)
        {
            //YOUR CODE HERE
            if (1 >= n)
                return 1;
            else
            {
                int factorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }

        public static int CalculateFactorialDec(int n)
        {
            //YOUR CODE HERE
            if (1 >= n)
                return 1;
            else
            {
                int factorial = 1;

                for (int i = n; i >= 1; --i)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }

        public static int CalculateFactorialRecursive(int n)
        {
            if (n < 1) return 1;
            else  return n * CalculateFactorialRecursive(n - 1);
        }
    }
}
