using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Aplikacja5
{
    class Program
    {
 
        [DllImport("msvcrt.dll")]
        private static extern void puts(string str); 

        [DllImport("msvcrt.dll")]
        private static extern void _flushall();

   
        static void Main(string[] args)
        {
            puts("Funkcja puts !@#$%");
            Console.ReadKey();
        }
    }
}
