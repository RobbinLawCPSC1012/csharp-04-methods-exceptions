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
            double windowWidth = getValue("Enter width of window in feet", 2.0, 6.0);
            Console.WriteLine($"Window Width: {windowWidth} feet");
            double age = getValue("Enter your age in years", 0, 70);
            Console.WriteLine($"Your Age is: {age} years");
            int num = getNum("Enter a integer number", 0, 1000);
            Console.WriteLine($"The entered number is: {num}");
            int num1 = getNum1("Enter a integer number", 0, 1000);
            Console.WriteLine($"The entered number is: {num1}");
        }

        static double getValue(
            string prompt, // prompt for the user 
            double low,    // lowest allowed value
            double high    // highest allowed value
            )
        {
            double result = low - 1;
            do
            {
                Console.WriteLine($"{prompt} between {low} and {high}:");
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }

        static int getNum(string prompt, int low, int high)
        {
            int num = low - 1;
            while ((num < low) || (num > high))
            {
                Console.WriteLine($"{prompt} between {low} and {high}:");
                string resultString = Console.ReadLine();
                num = int.Parse(resultString);
            }
            return num;
        }
        static int getNum1(string prompt, int low, int high)
        {
            int num = low - 1;
            bool inValidInput = true;
            while (inValidInput)
            {
                Console.WriteLine($"{prompt} between {low} and {high}:");
                string resultString = Console.ReadLine();
                num = int.Parse(resultString);
                if ((num < low) || (num > high)){
                    Console.WriteLine($"Error: Invalid Input.");
                }
                else {
                    inValidInput = false;
                }
            }
            return num;
        }
    }
}
