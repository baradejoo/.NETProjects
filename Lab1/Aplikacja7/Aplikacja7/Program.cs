using System;

namespace Aplikacja7
{
    class Program
    {
        static double toFahrenheit(double celsius) => celsius * 1.8 + 32.0;

        static double toKelvin(double celsius) => celsius + 273;

        static void Main(string[] args)
        {
            Console.Write("Podaj temperature w stopniach Celsjusza: ");
            var celsius = Double.Parse(Console.ReadLine());

            Console.WriteLine("{0}°C = {1}°F = {2}K", celsius, toFahrenheit(celsius), toKelvin(celsius));
        }
    }
}