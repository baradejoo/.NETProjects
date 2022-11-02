using System;
using System.Linq;

namespace Cw1
{
    struct Point2D
    {
        public double x;
        public double y;
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Reset()
        {
            this.x = 0;
            this.y = 0;
        }
        public void IncrX(double dx)
        {
            this.x = this.x + dx;
        }
        public void IncrY(double dy)
        {
            this.y = this.y + dy;
        }
        public void Print2DPoint()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
        public double Dist(Point2D other)
        {
            var tmp1 = this.x - other.x;
            var tmp2 = this.y - other.y;
            return Math.Sqrt(tmp1 * tmp1 + tmp2 * tmp2);
        }
    }

    class Program
    {

        static Point2D ReadInput()
        {
            Console.Write("X: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            var y = Convert.ToDouble(Console.ReadLine());
            return new Point2D(x, y);
        }

        static void Main(string[] args)
        {
            const int amount = 4;
            const float rad = 1;

            Console.WriteLine($"Enter {amount} circle coordinates");
            var circles = new Point2D[amount];
            for (var i = 0; i < amount; i++)
            {
                circles[i] = ReadInput();
            }

            Console.WriteLine("Enter a point's coordinates");
            do
            {
                var point = ReadInput();
                if (point.x < 0 || point.y < 0)
                {
                    break;
                }

                var foundCircle = circles.FirstOrDefault(circle => circle.Dist(point) < rad);

                Console.WriteLine($"Point inside the circle of radius = {rad} and center at:");
                foundCircle.Print2DPoint();

            } while (true);

            Console.WriteLine("All circle centers:");
            foreach (var circle in circles)
            {
                circle.Print2DPoint();
            }

            Console.ReadLine();
        }
    }
}