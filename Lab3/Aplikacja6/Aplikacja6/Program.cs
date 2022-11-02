using System;
using System.Linq;

namespace Aplikacja6
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = string.Join(" ", Console.ReadLine().ToCharArray());
            Console.WriteLine(result);
        }
    }
}