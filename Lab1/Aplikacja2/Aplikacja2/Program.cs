using System;

namespace Aplikacja2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jak zaczął jako int, to ucina wyniki operacji do części całkowitej
            Console.WriteLine("5 + 5 = " + (5 + 5));
            Console.WriteLine("8 / 2 = {0}", 8 / 2);
            // trzeba explicite zacząć jako double
            Console.WriteLine("7.0 / 2 = {0}", 7.0 / 2);
            Console.WriteLine("-1 + 4 * 6 = {0}", -1 + 4 * 6);
            Console.WriteLine("(35 + 5) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6/11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15/6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);
        }
    }
}