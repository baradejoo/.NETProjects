using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja7
{
    class Program
    {
        static void Main(string[] args)
        {
   
            int attempt1 = Int32.MaxValue;
            // to wyrzuca błąd w runtime:
            // Unhandled Exception: System.OverflowException: Arithmetic operation
            // resulted in an overflow.

            //attempt1 = checked(attempt1 + 1);
            Console.WriteLine(attempt1);

            int a = attempt1;
            try
            {
                checked
                {
                    Console.WriteLine(a + 1);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
            }

        }
    }
}
