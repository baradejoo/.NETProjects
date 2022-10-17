using System;

namespace Aplikacja8
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0);

            // xor, ale zero jest uznawane za dotatnia
            Console.WriteLine(num1 >= 0 ^ num2 >= 0);
        }
    }
}