using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_try_catch_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt1 = getIntInput1($"Please enter a positive integer value: ");
            myInt1++;
            Console.WriteLine($"The incremented input is: {myInt1}");
            int myInt2 = getIntInput2($"Please enter a positive integer value: ");
            myInt2++;
            Console.WriteLine($"The incremented input is: {myInt2}");
            int myInt3 = letUsDoThisRight($"Please enter a positive integer value: ");
            myInt3++;
            Console.WriteLine($"The incremented input is: {myInt3}");
        }

        static int getIntInput1(String msg)
        {
            bool validInput = false;
            int num = 0;
            while (!validInput)
            {
                Console.Write(msg);
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                    validInput = true;
                else
                    Console.WriteLine("Invalid Input. Number must be bigger than zero.");
            }
            return num;
        }
        static int getIntInput2(String msg)
        {
            bool validInput = false;
            int num = 0;
            while (!validInput)
            {
                Console.Write(msg);
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                        validInput = true;
                    else
                        Console.WriteLine("Invalid Input. Number must be bigger than zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }
            }
            return num;
        }
        static int getIntInput3(String msg)
        {
            bool validInput = false;
            int num = 0;
            while (!validInput)
            {
                Console.Write(msg);
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                        validInput = true;
                    else
                        throw new Exception("Invalid Input. Number must be bigger than zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in getIntInput3: {ex.Message}");
                    throw;
                }
            }
            return num;
        }
        static int letUsDoThisRight(String msg)
        {
            bool validInput = false;
            int num = 0;
            while (!validInput)
            {
                try
                {
                    num = getIntInput3(msg);
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in letUsDoThisRight: {ex.Message}");
                }
            }
            return num;
        }
    }
}
