using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1
{
    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    class Program
    {
        static void Fun1(in int i)
        {
            // i = 1; // BLAD, ERROR: The assignment target must be an assignable variable, property or indexer
        }
        static void Fun2(out int i)
        {
            i = 2;
        }
        static void Fun3(ref int i)
        {
            i = 3;
        }

        static void Fun4(int i)
        {
            i = 4;
        }

        static void Fun5(Point p)
        {
            p = new Point(1, 1);
        }
        static void Fun6(ref Point p)
        {
            p = new Point(2, 2);
        }

        static void Main(string[] args)
        {
            // Exercise 1
            int a = 0;
            Fun1(a); // pusta funkcja
            Console.WriteLine($"Fun1: {a}"); // Wynik pustej funkcji: 0

            Fun2(out a); // jak jest out to a jest zmienione
            Console.WriteLine($"Fun2: {a}"); // Wynik to: 2

            Fun3(ref a); // poprzez ref tez mozna to osiagnac
            Console.WriteLine($"Fun3: {a}"); // Wynik to: 3

            // int przekazany przez wartosc, wiec funkcja go nie zmieni
            Fun4(a);
            Console.WriteLine($"Fun4: {0}", a); // Wynik to: bez zmian


            short a_short = 0;
            Fun1(a_short); // jest pusta
            Console.WriteLine($"short Fun1: {a_short}"); // Wynik to: 0

            // Fun2(out shortInput); // BLAD, error: The 'out' argument type doesn't match parameter type
            // Fun3(ref shortInput); // BLAD, error: The 'ref' argument type doesn't match parameter type

            Fun4(a_short);   // j.w. w przypadku int
            Console.WriteLine($"short Fun4: {a_short}"); // Wynik to: 0

            Point p1 = new Point(0, 0);
            Fun5(p1);   // przez wartosc, wiec bez zmian
            Console.WriteLine($"point Fun5: x={p1.x}, y={p1.y}"); // Wynik to: (0, 0)

            Fun6(ref p1);   // przez referencje, wiec zmiana nastepuje
            Console.WriteLine($"point Fun6: x={p1.x}, y={p1.y}"); // Wynik to: (2, 2)

            p1 = null;
            // System.NullReferenceException - bo odwolujemy sie do nulla
            // Console.WriteLine($"point null assignment: x={p1.x}, y = {p1.y}");

            Fun6(ref p1);   // null jest nadpisany przez nowy obiekt
            Console.WriteLine($"null Fun6: x={p1.x}, y={p1.y}"); // Wynik to: (2, 2)

            Console.ReadLine();
        }
    }
}
