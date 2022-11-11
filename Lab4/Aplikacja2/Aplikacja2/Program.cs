using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja2
{
    class Program
    {
        // Ta funkcja zamienia wartosci w komórkach pamieci na ktore wskazuja wskazniki
        public unsafe static void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }

        // slowo unsafe jest wymagane, inaczej kompilator sie czepia ze robimy niebezpieczne rzeczy bez uprzedzenia
        public unsafe static void Main(string[] args)
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)
            {
                for (int i = 0; i < 3; i++)
                {
                    var addr = (int)(ptr + i);
                    var val = *(ptr + i);
                    Console.WriteLine($"Adres [{i}]=0x{addr:x8}");
                    Console.WriteLine($"Wartość [{i}]={val}");
                }
            }

            int x = 1;
            int y = 2;
            swap(&x, &y);
            Console.WriteLine($"x = {x}, y = {y}");

            int[] buffer = new int[1024];
            fixed (int* buffPtr = buffer)
            {
                for (int i = 0; i < 1024; i++)
                {
                    // przypisuje jakies wartosci z operacji modulo
                    *(buffPtr + i) = i % 5;
                }
                for (int i = 0; i < 40; i++)
                {
                    // odczytuje tylko dla 40 elementow zeby nie zasmiecic konsoli
                    var val = *(buffPtr + i);
                    Console.WriteLine($"Wartość [{i}]={val}");
                }
            }
            Console.ReadKey();
        }
    }
}
