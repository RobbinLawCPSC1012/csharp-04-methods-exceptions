using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_methods_EqOfLine
{
    class Program
    {

        static double compute_slope ( int x1, int y1, int x2, int y2 )
        {
           double slope;
           slope = (y2 - y1)/(x2 - x1);
           return slope;
        }

        /* Calculates the Y intercept of the line. */
        static double compute_intercept ( int x1, int y1, double slope )
        {
           double intercept;
           intercept = y1 - slope * x1;
           return intercept;
        }

        static void Main(string[] args)
        {
           int x1, x2, y1, y2;
           double slope, intercept;
           Console.WriteLine("please enter the X coordinate of the first point: ");
           x1= int.Parse(Console.ReadLine());
           Console.WriteLine("please enter the X coordinate of the second point: ");
           x2= int.Parse(Console.ReadLine());
           Console.WriteLine("please enter the Y coordinate of the first point: ");
           y1= int.Parse(Console.ReadLine());
           Console.WriteLine("please enter the Y coordinate of the second point: ");
           y2= int.Parse(Console.ReadLine());
           slope = compute_slope (x1, y1, x2, y2);
           intercept = compute_intercept(x1, y1, slope);
           Console.WriteLine($"The slope is {slope}, and the intercept is {intercept}");
        }
    }
}
