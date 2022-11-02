using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja4
{
        public enum Dni
        {
            Pon = 1,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela,
        }
        public enum Rozmiar
        {
            Mala_liczba = 10,
            Srednia_liczba = 100,
            Duza_liczba,
        }

        class Program
        {
            static Rozmiar getNumberSize(int number) =>
                (number < (int)Rozmiar.Mala_liczba) ? Rozmiar.Mala_liczba :
                    number < (int)Rozmiar.Srednia_liczba ? Rozmiar.Srednia_liczba :
                        Rozmiar.Duza_liczba;

            static void Main(string[] args)
            {
                Dni day = (Dni)Enum.Parse(typeof(Dni), Console.ReadLine());
                Console.WriteLine(day);

                var number = int.Parse(Console.ReadLine());
                var size = getNumberSize(number);
                Console.WriteLine($"{number} is {size.ToString()} size");

                Console.ReadLine();
            }
        }

}
