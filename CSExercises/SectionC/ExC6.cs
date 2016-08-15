using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            //bool isValidCode = false;
            bool isValidQtyofTV = false;
            bool isValidQtyofDVD = false;
            bool isValidQtyofMP3 = false;
            bool stop = false;

            int tvQty = 0;
            int dvdQty = 0;
            int mp3Qty = 0;

            string productCode = "";

            while (false == stop)
            {
                Console.Write("Enter product code (TV | DVD | MP3): ");
                productCode = Console.ReadLine();

                switch (productCode)
                {
                    case "TV":
                        while (false == isValidQtyofTV)
                        {
                            Console.Write("Input quantity of TV: ");
                            isValidQtyofTV = int.TryParse(Console.ReadLine(), out tvQty);
                        }
                        break;

                    case "DVD":
                        while (false == isValidQtyofDVD)
                        {
                            Console.Write("Input quantity of DVD: ");
                            isValidQtyofDVD = int.TryParse(Console.ReadLine(), out dvdQty);
                        }
                        break;

                    case "MP3":
                        while (false == isValidQtyofMP3)
                        {
                            Console.Write("Input quantity of MP3: ");
                            isValidQtyofMP3 = int.TryParse(Console.ReadLine(), out mp3Qty);
                        }
                        break;
                    default:
                        break;
                }

                if (true == isValidQtyofTV && true == isValidQtyofDVD && true == isValidQtyofMP3)
                    stop = true;
            }

            Console.WriteLine("Total price: {0:c}", CalculateTotalPrice(tvQty, dvdQty, mp3Qty));
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double totalPrice = tvQty * 900 + dvdQty * 500 + mp3Qty * 700;

            if (5000 < totalPrice 
                && totalPrice < 10000
                && ((0 < tvQty) || (0 < dvdQty)))
            {
                totalPrice = totalPrice * 90 / 100;
            }
            else if (10000 < totalPrice
                && ((0 < tvQty) || (0 < dvdQty)))
            {
                totalPrice = totalPrice * 85 / 100;
            }

            return totalPrice;
        }
    }
}