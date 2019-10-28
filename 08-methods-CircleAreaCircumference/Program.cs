using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods_CircleAreaCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = getNumber("Enter Circle Radius", 2.0, 6.0);
            Console.WriteLine($"The Circle Area is: {circleArea(radius):n2}");
            Console.WriteLine($"The Circle Circumference is: {circleCircumference(radius):n2}");
            
        }

        static double getNumber(string prompt, double low, double high)
        {
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine($"{prompt} between {low:n1} and {high:n1}: ");
                num = double.Parse(Console.ReadLine());
                if (num >= low && num <= high)
                    invalidInput = false;
                else
                    Console.WriteLine("Error: Invalid Input.");
            }
            return num;
        }
        static double circleArea(double radius)
        {
            return (Math.PI * radius * radius);
        }
        static double circleCircumference(double radius)
        {
            return (2 * Math.PI * radius);
        }
    }
}
