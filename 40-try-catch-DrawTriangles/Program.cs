using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_try_catch_DrawTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetNumber("Enter the number of rows", 1, 10);
            char c = GetCharacter("Enter a character to print: ");
            Console.WriteLine("\nDefault");
            DrawTriangle(num);
            Console.WriteLine("\nCustom");
            DrawTriangle(num, c);
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

        static void DrawTriangle(int rows)
        {
            char c = '*';
            DrawTriangle(rows, c);
        }

        static void DrawTriangle(int rows, char drawChar)
        {
            for (int i = 1; i <= rows; i++)
            {
                DrawRow(i, drawChar);
            }
        }

        static void DrawRow(int len, char c)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(c);
            }
            Console.Write("\n");
        }
    }
}
