using System;

namespace Cwiczenie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            var pierwsza = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            var druga = int.Parse(Console.ReadLine());

            Console.WriteLine($"Drugi Numer: {druga}\t . Pierwszy Numer: {pierwsza}.");
        }
    }
}