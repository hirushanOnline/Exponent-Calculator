using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponent_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your prefered Base Number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your prefered Power Number: ");
            int powNumber = Convert.ToInt32(Console.ReadLine());

            //Newline added
            Console.WriteLine();
            
            //calling the Getpow function
            Console.WriteLine("Exponent of Base Number " + baseNumber + " to the power of " + powNumber + " is: " + Getpow(baseNumber, powNumber));
            
            //Newline added
            Console.WriteLine();

            Console.WriteLine("Thank You for using our Applicaiton!");
            Console.ReadLine();
        }

        static int Getpow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i =0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
