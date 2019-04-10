using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosOrNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program is used to determine if the numbers the user inputs would result in a positive or negative answer if multiplied. However, it does NOT do the actual math. It
             * only is determining the status of the result. 2 pos = pos, 2 negs = pos, 1 pos * 1 neg = neg*/

            Console.WriteLine("Let's determine if the two numbers you enter will result in a positive or negative answer if multiplied.");
            Console.WriteLine("Please enter your first number:");
            string input = Console.ReadLine();
            int number1 = Convert.ToInt32(input);

            Console.WriteLine("Please enter your second number:");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            //No matter what one input is, if the other is '0', the answer will be '0'
            if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("As you have entered a '0' as one of your numbers, your result will be neither positive nor negative.");
            }

            else
            {
                //Determine if either inputs are positive
                bool num1Positive;
                bool num2Positive;

                if (number1 > 0) { num1Positive = true; }
                else { num1Positive = false; }

                if (number2 > 0) { num2Positive = true; }
                else { num2Positive = false; }

                //If both numbers have the same sign, then the result will be positive
                if ((num1Positive && num2Positive) || (!num1Positive && !num2Positive))
                {
                    Console.WriteLine("Your result will be a positive number.");
                }
                else //The signs are mixed, so the result is negative
                {
                    Console.WriteLine("Your result will be a negative number.");
                }

                Console.ReadKey();
            }
        }
    }
}
