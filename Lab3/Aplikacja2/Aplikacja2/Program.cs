using System;

namespace Aplikacja2
{
    struct Point2D_noConstructor
    {
        private double x;
        private double y;
    }
    
    class Point2D_Priv
    {
        private double x;
        private double y;
        public Point2D_Priv() { }
    }

    class Point2D_Init
    {
        // struct cannot be initialized here
        // it has to be a class
        public double x = 2;
        private double y = 3;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point2D_noConstructor point;

            // Console.WriteLine(point.ToString()); - blad

            point = new Point2D_noConstructor();
            Console.WriteLine(point.ToString()); // pokazuje nazwe

            var point2 = new Point2D_Priv();
            Console.WriteLine(point2.ToString()); // pokazuje nazwe

            var point3 = new Point2D_Init();
            Console.WriteLine(point3.x); // mozna przypisac wartosci do zmiennych klasowych domyslne
        }
    }
}