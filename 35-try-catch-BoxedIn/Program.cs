using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_try_catch_BoxedIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetNumber("Enter the number of rows", 1, 10);
            char c = GetCharacter("Enter a character to print: ");
            DrawBox(num, c);
        }

        static int GetNumber(string prompt, int low, int high)
        {
            bool invalidInput = true;
            int num = 0;

            while (invalidInput)
            {
                try
                {
                    Console.WriteLine($"{prompt} between {low} and {high}: ");
                    num = int.Parse(Console.ReadLine());
                    if (num >= low && num <= high)
                        invalidInput = false;
                    else
                        Console.WriteLine("Error: Invalid Input.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return num;
        }

        static char GetCharacter(string msg)
        {
            bool validInput = false;
            char c = 'c';

            while (!validInput)
            {
                Console.Write(msg);
                try
                {
                    c = char.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return c;
        }
        static void DrawBox(int rows, char drawChar)
        {
            for (int i = 1; i <= rows; i++)
            {
                DrawRow(rows, drawChar);
                Console.Write($"\n");
            }
        }
        static void DrawRow(int rows, char drawChar)
        {
            for (int i = 1; i <= rows; i++)
            {
                Console.Write($"{drawChar}");
            }
        }
    }
}
