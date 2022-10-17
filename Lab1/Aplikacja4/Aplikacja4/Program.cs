using System;

namespace Cwiczenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj 3 liczby (oddzielone 1x spacja): ");
            var input = Console.ReadLine().Split(' ');
            var a = Convert.ToInt32(input[0]);
            var b = Convert.ToInt32(input[1]);
            var c = Convert.ToInt32(input[2]);
            Console.WriteLine($"{c} x {b} x {a} = {a * b * c}");
        }
    }
}