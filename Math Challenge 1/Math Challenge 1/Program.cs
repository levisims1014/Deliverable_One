using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            var b1 = 0;
            var b2 = 0;
            var sum = 0;

            //keeps program returning to the beginning without closing
            while (true)
            {
                //asking for user input
                Console.WriteLine("Enter a number:  ");
                //printing user input and converting user input from string to int
                b1 = Convert.ToInt32(Console.ReadLine());

                //asking for user input
                Console.WriteLine("Enter a number:  ");
                //printing user input and coverting user input from string to int
                b2 = Convert.ToInt32(Console.ReadLine());

                //getting the sum of user input
                sum = b1 + b2;
                //printing the sum
                Console.WriteLine("sum: " + sum);

                //making the sum a string and setting index to 0
                var first = sum.ToString()[0];
                //declaring variable allEqual
                var allEqual = true;
                //tells program to continue getting sum of digits by going to next digit in line
                for (int something = 0; something < sum.ToString().Length; something++)

                        //when the sum of the numbers are not equal break from loop
                        if (sum.ToString()[something] != first)
                    {
                        allEqual = false;

                        break;

                    }
                // if sum of all digits match print true
                if (allEqual)
                {
                    Console.WriteLine("True");
                }

                else
                {
                    //If sum of all digits does not match print false
                    Console.WriteLine("False");
                    Console.ReadLine();
                }
            }
        }
    }
}
