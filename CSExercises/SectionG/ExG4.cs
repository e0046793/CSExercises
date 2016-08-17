using System;
using System.Linq;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string[] arrName = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] arrMark = { 63, 29, 75, 82, 55 };

            int[] arrSortedMark = arrMark.OrderByDescending(c => c).ToArray();
            for (int i = 0; i < arrMark.Length; ++i)
            {
                Console.Write("{0}\t", arrSortedMark[i]);
            }
            Console.WriteLine();
            Array.Sort(arrName, (x, y) => String.Compare(x, y));
            for (int i = 0; i < arrName.Length; ++i)
            {
                Console.Write("{0}\t", arrName[i]);
            }
        }
    }
}
