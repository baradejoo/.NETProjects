using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja2_4
{
    class Program
    {
        static void Cwiczenie2()
        {
            Console.WriteLine("Cwiczenie 2");
            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32) o);

            // System.InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System.Int64'.
            // long j = (long) o;
            // Console.WriteLine(o);

            Console.WriteLine();
        }
        static void Cwiczenie3()
        {
            Console.WriteLine("Cwiczenie 3");
            // tworze obiekt typu Nullable -> taki ktory przechowuje wartosc 'null'
            int? myNullable = null;

            // albo:
            // Nullable<int> myNullable = null;
            Console.WriteLine($"Raw: {myNullable}");

            // metoda GetOrDefault zwroci wartosc domyslna, gdy jest null
            Console.WriteLine($"HasValue to: {myNullable.HasValue}");
            Console.WriteLine($"GetOrDefault to: {myNullable.GetValueOrDefault(-1)}");

            if (myNullable.HasValue)
            {
                Console.WriteLine("To sie nie wykona");
            }

            myNullable = 22;
            Console.WriteLine("Po przypisaniu wartosci:");
            Console.WriteLine($"HasValue to: {myNullable.HasValue}");
            Console.WriteLine($"GetOrDefault to: {myNullable.GetValueOrDefault(-1)}");
            Console.WriteLine();
        }
        static void Cwiczenie4()
        {
            Console.WriteLine("Cwiczenie 4");
            int? i = null;
            int j = 10;
            // "Expression is always false"
            // czyli porównywanie z nullem zawsze zwróci false
            Console.WriteLine(i < j);
            Console.WriteLine(i > j);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Cwiczenie2();
            Cwiczenie3();
            Cwiczenie4();
            Console.ReadKey();
        }
    }
}