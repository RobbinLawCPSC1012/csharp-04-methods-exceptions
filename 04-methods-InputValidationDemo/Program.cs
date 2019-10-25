using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_methods_InputValidationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double windowWidth = getValue(
            "Enter width of window in feet ", 2.0, 6.0);

            Console.WriteLine($"Window Width: {windowWidth} feet");

            double age = getValue("Enter your age in years ", 0, 70);

            Console.WriteLine($"Your Age is: {age} years");

            int num = getNum("Enter a integer number ", 0, 1000);

            Console.WriteLine($"The entered number is: {num}");
        }

        static double getValue(
            string prompt, // prompt for the user 
            double low,    // lowest allowed value
            double high    // highest allowed value
            )
        {
            double result = 0;
            do
            {
                Console.WriteLine(prompt +
                   " between " + low +
                    " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }

        static int getNum(string prompt, int low, int high)
        {
            Console.WriteLine(prompt +
                   " between " + low +
                    " and " + high);
                string resultString = Console.ReadLine();
                int num = int.Parse(resultString);

            if (num <= 0 || num >= 1000) {
                return getNum("Enter a integer number ", 0, 1000);
            }

            return num;
        }
    }
}
