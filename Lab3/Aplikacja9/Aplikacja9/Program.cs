using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja9
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Replace(" ", "");
            var supported_Operators = new[] { '+', '-' };
            var rawNums = input.Split(supported_Operators);
            var ops = input.Split(rawNums, StringSplitOptions.RemoveEmptyEntries);
            if ((rawNums.Length + ops.Length) % 2 == 0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
                return;
            }

            var numbers = new int[rawNums.Length];

            if (rawNums.Where((t, i) => !int.TryParse(t, out numbers[i])).Any())
            {
                Console.WriteLine("Error: Non-numeric input");
                Console.ReadLine();
                return;
            }

            var sum = numbers[0];
            for (var i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "+":
                        sum += numbers[i + 1];
                        break;
                    case "-":
                        sum -= numbers[i + 1];
                        break;
                    default:
                        Console.WriteLine("Unsupported operator");
                        Console.ReadLine();
                        return;
                }
            }
            Console.WriteLine($"Wynik: {sum}");
            Console.ReadLine();
        }
    }
}
