using System;

namespace Aplikacja3
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;
            float float_num;
            int n_Strings = 0;
            int n_Ints = 0;
            int n_Floats = 0;

            do
            {
                string read = Console.ReadLine();

               
                n_Strings++;

                if (int.TryParse(read, out integer))
                    n_Ints++;

                if (float.TryParse(read, out float_num))
                    n_Floats++;

                Console.WriteLine(integer);

            } while (Console.ReadLine() != "-1");

            Console.WriteLine($"Strings: {n_Strings}, ints: {n_Ints}, floats: {n_Floats}");
        }
    }
}