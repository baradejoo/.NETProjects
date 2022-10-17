using System;

namespace Aplikacja5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            const int width = 4;
            const int height = 6;

            Console.Write("Podaj cyfre: ");
            var x = Console.ReadLine();
            var ch = x[0]; // przypadek kiedy ktos poda 2cyfrowa liczbe

            Console.WriteLine(" {0} ", new string(ch, width));
            for (int i = 0; i < height; i++)
                Console.WriteLine("{0}{1}{0}", ch, new string(' ', width));
            Console.WriteLine(" {0} ", new string(ch, width));
        }
    }
}