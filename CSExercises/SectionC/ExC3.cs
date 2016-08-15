using System;

namespace CSExercises
{
    //3.	Write a program that would compute the grade for a mark that the student gets.  The program should take an integer number between 0 and 100 and print the following:
    //You scored 73 marks which is B grade.
    //where 73 is the input and B is calculated by the program.  Use the following table for computing the grades:

    //Marks         Grade
    //80 to 100	    A
    //60 to 79	    B
    //40 to 59	    C
    //0 to 40	    F
    //< 0  	        **Error**
    //> 100	        **Error**

    public class ExC3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your mark: ");

            int mark; ;
            bool isConverted = int.TryParse(Console.ReadLine(), out mark);

            if (false == isConverted)
            {
                Console.WriteLine("Input must be numeric!!!");
            }
            else
            {
                string grade = CalculateGrade(mark);
                Console.WriteLine("You scored {0} marks which is {1} grade.", mark, grade);
            }

        }

        public static string CalculateGrade(int mark)
        {
            //YOUR CODE HERE
            if (80 <= mark && mark <= 100)
            {
                return "A";
            }
            else if (60 <= mark && mark <= 79)
            {
                return "B";
            }
            else if (40 <= mark && mark <= 59)
            {
                return "C";
            }
            else if (0 <= mark && mark <= 39)
            {
                return "F";
            }
            return "**Error**";
        }
    }
}