using System;

namespace CSExercises
{
    //Write a program that would request for your name, 
    //gender and age and would print a greeting like this:
    //Good morning Uncle Sam( if Sam, M, 45 is entered)
    //(any gentlemen 40 years or more is Uncle any lady 
    //40 years or more is Aunty, if less than forty they 
    //become just Mr or Ms. as the case may be.)


    public class ExC2
    {
        public static void Main(string[] args)
        {
            String title = "";

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //YOUR CODE HERE
            if (string.Equals(gender, "M", StringComparison.OrdinalIgnoreCase)
                || string.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase))
            {
                title = "Mr. ";
                if (40 <= age) title = "Uncle ";
            }
            else if (string.Equals(gender, "F", StringComparison.OrdinalIgnoreCase)
                || string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
            {
                title = "Ms. ";
                if (40 <= age) title = "Aunty ";
            }

            Console.WriteLine("Good Morning " + title + name);
        }
    }
}