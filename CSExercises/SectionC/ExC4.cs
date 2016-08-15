using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {
            // Define variables
            double distance = 0.0;

            // Get the input
            bool isValidInput = false;

            while (false == isValidInput)
            { 
                Console.Write("Please enter your distance (kilometers): ");
                bool isConvertedInput = double.TryParse(Console.ReadLine(), out distance);

                if (false == isConvertedInput)
                {
                    Console.WriteLine("\nPlease input numeric!!!\n");
                }
                else
                {
                    if (distance < 0) Console.WriteLine("\nSystem accepts only positive number!!!\n");
                    else isValidInput = true;

                }
            }

            double roundedValue = 10.0;
            distance = Math.Ceiling(distance * roundedValue) / roundedValue;
            Console.WriteLine("Distance travelled after rounded: {0}", distance);
            double fare = CalculateFare(distance);
            Console.WriteLine("Total fare: {0}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double baseFare = 2.40; //Have to pay first 0.5km
            double totalFare;

            if (0.5 >= distance)
            {
                totalFare = baseFare;
            }
            else if ((distance - 0.5) <= 8.5)
            {
                totalFare = baseFare + 0.04 * (distance - 0.5) * 10;
            }
            else
            {
                totalFare = baseFare + 0.04 * 8.5 * 10 + 0.05 * (distance - 9) * 10;
            }

            return totalFare;
        }
    }
}