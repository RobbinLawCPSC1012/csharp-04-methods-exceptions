using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_methods_BoxedIn_EditedRLaw2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetNumber("Enter the number of rows between 1 and 10: ");
            char c = GetCharacter("Enter a character to print: ");
            DrawBox(num, c);
        }

        static int GetNumber(string msg)
        {
            bool invalidInput = true;
            int num = 0;

            while (invalidInput)
            {
                Console.Write(msg);
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num <= 10)
                    invalidInput = false;
                else
                    Console.WriteLine("Invalid Input. Number must be bigger than zero.");
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
                c = char.Parse(Console.ReadLine());
                validInput = true;
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

        static void DrawRow(int rows, char drawChar){
            for(int i =1; i <= rows; i++){
                Console.Write($"{drawChar}");
            }
}
    }
}
