using System;

namespace Aplikacja6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ii = 75400;
            double id = 7.54;
            string s1 = string.Format("Wartość int to {0}, a wartość double to {1}",
                ii, id);
            Console.WriteLine(s1);
            Console.WriteLine("Int to " + ii.ToString() + ", a string to " + id.ToString());
            Console.WriteLine("---{0,40}--- ---{0,-40}---", ii);
            Console.WriteLine("---{0,40}--- ---{0,-40}---", id);
            int i = 57300;
            double d = 5.73;
            Console.WriteLine("---{0:c}---", i);
            Console.WriteLine("---{0:d}---", i);
            Console.WriteLine("---{0:e}---", i);
            Console.WriteLine("---{0:f}---", i);
            Console.WriteLine("---{0:x}---", i);
            Console.WriteLine("---{0:c}---", d);
            Console.WriteLine("---{0:e}---", d);
            Console.WriteLine("---{0:f}---", d);
            Console.WriteLine("---{0:r}---", d);
            float flo = 220.022f;
            Console.WriteLine("{0:0.00000}", flo);
            Console.WriteLine("{0:[#].(#) (##)}", flo);
            Console.WriteLine("{0:0.0}", flo);
            Console.WriteLine("{0:0,0}", flo);
            Console.WriteLine("{0:,.}", flo);
            Console.WriteLine("{0:0%}", flo);
            Console.WriteLine("{0:0e+0}", flo);
            float f1 = 123.4f, f2 = -1234, f3 = 0;
            Console.WriteLine("{0:#,##0.0; (#,##)Minus;Zero}", f1);
            Console.WriteLine("{0:#,##0.0; (#,##)Minus;Zero}", f2);
            Console.WriteLine("{0:#,##0.0; (#,##)Minus;Zero}", f3);
            DateTime date = System.DateTime.Now;
            Console.WriteLine("{0:d}", date);
            Console.WriteLine("{0:D}", date);
            Console.WriteLine("{0:t}", date);
            Console.WriteLine("{0:T}", date);
            Console.WriteLine("{0:f}", date);
            Console.WriteLine("{0:F}", date);
            Console.WriteLine("{0:g}", date);
            Console.WriteLine("{0:G}", date);
            Console.WriteLine("{0:M}", date);
            Console.WriteLine("{0:r}", date);
            Console.WriteLine("{0:s}", date);
            Console.WriteLine("{0:u}", date);
            Console.WriteLine("{0:U}", date);
            Console.WriteLine("{0:Y}", date);
        }
    }
}