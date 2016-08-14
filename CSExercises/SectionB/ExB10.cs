using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double triangleSide1, triangleSide2, triangleSide3;
            bool isTriangleValid = true;

            Console.Write("Input triangle side 1: ");
            triangleSide1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input triangle side 2: ");
            triangleSide2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input triangle side 3: ");
            triangleSide3 = Convert.ToDouble(Console.ReadLine());

            if ((triangleSide1 + triangleSide2 - triangleSide3 <= 0) ||
                    (triangleSide1 + triangleSide3 - triangleSide2 <= 0) ||
                    (triangleSide2 + triangleSide3 - triangleSide1 <= 0)) {
                isTriangleValid = false;
            }

            Console.WriteLine("======================================");
            
            if (isTriangleValid)
            {
                Console.WriteLine("Area of triangle is: {0:0.##}", CalculateArea(triangleSide1, triangleSide2, triangleSide3));
            }
            else
            {
                Console.WriteLine("It is not a valid triangle!!!");
            }
        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}