using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 3:");
            Cw3();

            Console.WriteLine("Cwiczenie 4:");
            Cw4();

            Console.WriteLine("Cwiczenie 6:");
            Cw6();

            Console.WriteLine("Cwiczenie 8:");
            Cw8();
        }

        static void Cw3()
        {
            var table = new int[10];
            var num = 0;
            while (num < 10)
            {
                Console.WriteLine("Next int:");
                var line = Console.ReadLine();

                if (!int.TryParse(line, out var input)) break;

                for (var i = num; i > 0; i--)
                    table[i] = table[i - 1];

                table[0] = input;
                num++;

                Console.WriteLine("Array contents:");
                foreach (var i in table)
                    Console.Write($" {i}");

                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Cw4()
        {
            var table = new int[5];
            for (var i = 0; i < 5; i++)
                table[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Odwrocona:");
            foreach (var i in table.Reverse())
                Console.WriteLine(i);

            Console.ReadLine();
        }



        static void Cw6()
        {
            int[,] table1 = { { 2, 2, 2, 323, 3 },
                { 1, 1, 331, 1, 1 },
                { 1, 4, 1, 3, 1 },
                { 12, 1, 321, 2, 1 },
                { 1, 12, 1, 1, 1 } };
            int[,] table2 = { { 2, 2, 2, 2, 2 },
                { 1, 2, 12, 2, 2 },
                { 1, 2, 22, 3, 2 },
                { 2, 22, 2, 2, 2 },
                { 2, 2, 12, 2, 43 } };
            var table3 = new int[5, 5];
            for (var i = 0; i < table1.GetLength(0); i++)
            {
                for (var j = 0; j < table1.GetLength(1); j++)
                {
                    table3[i, j] = table1[i, j] + table2[i, j];
                    Console.Write($" {table3[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Length = {table3.Length}");
            Console.WriteLine($"LongLength = {table3.LongLength}");
            Console.WriteLine($"Rank = {table3.Rank}");
            Console.ReadLine();
        }

        static void Cw8()
        {
            var arr1 = new int[5][];
            arr1[0] = new[] { 1, 2, 3 };
            arr1[1] = new[] { 4, 5, 6, 7, 8, 9 };
            arr1[2] = new[] { 10, 11, 12, 13 };
            arr1[3] = new[] { 14, 15, 16, 17, 18 };
            arr1[4] = new[] { 19, 20, 21 };
            int[][] arr2 =
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6, 7, 8, 9 },
                new[] { 10, 11, 12, 13 },
                new[] { 14, 15, 16, 17, 18 },
                new[] { 19, 20, 21 }
            };

            void print2DArray(int[][] arr)
            {
                foreach (var i in arr)
                {
                    foreach (var val in i)
                    {
                        Console.Write($" {val} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Arr1:");
            print2DArray(arr1);

            Console.WriteLine("Arr2:");
            print2DArray(arr2);

            Console.ReadLine();
        }

    }
}
