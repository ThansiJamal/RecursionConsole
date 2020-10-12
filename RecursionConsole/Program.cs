using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecursionConsole
{
    class Program
    {
        static int i = 1;
        static void Main(string[] args)
        {
            Add();
            Console.ReadKey();
        }
       public static void Add()
        {
            Thread.Sleep(500);
            Console.WriteLine(i.ToString());
            i++;
            if(i==11)
            {
                return;
            }
            Add();
        }
        
        
    }
}
