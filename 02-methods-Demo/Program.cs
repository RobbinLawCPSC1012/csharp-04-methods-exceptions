using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_methods_Demo
{
    class Program
    {
        static void printHello(){  // simplest method with no parameters and no return
            Console.WriteLine($"Hello");
        }
        
        static void printIt(String myString, int myInt){ // intermediate method with parameters but no return
            Console.WriteLine($"Hey my string is: {myString}, and my int is {myInt}");
        }


        static int add(int n1, int n2){ // most complicated method with parameters and a return value
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            int x;
            String s;

            printHello();
            printIt("fun", 2);
            x = add(2,3);
            s = x.ToString();
            printIt(s, x);
        }


        
    }
}
