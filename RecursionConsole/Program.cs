using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionConsole
{
    class Program
    {

        static void PrintNumber(int i)
        {
            if (i > 10)
                return;
            Console.WriteLine(i + " ");
            PrintNumber(i + 1);

        }
        static void Main(string[] args)
        {
            PrintNumber(1);
            Console.ReadKey();
        }
        //static void PrintNumber(int i)
        //{
        //    if (i > 0)
        //    {
        //        PrintNumber(i - 1);
        //        Console.WriteLine(i + " ");
        //    } 
        //        return;


        //}
        //static void Main(string[] args)
        //{
        //    PrintNumber(10);
        //    Console.ReadKey();
        //}

    }
}
