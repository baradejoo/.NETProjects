using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab10
{
    public class Program
    {
        private static readonly Random Random = new();
        
        // zmienna wspoldzielona miedzy watkami
        private static List<string> lines = new();
        
        /**
         * Zastanawiałem się, czy nie użyć jednak nowoczesnego rozwiązania
         * z klasą Task i async/await. Fajnie byłoby omówić to na zajęciach
         */
        public static void Main()
        {
            // wątek w tle generuje za każdym razem drzewo
            // i nadpisuje zawartość linijek do wyświetlenia
            ThreadStart job = () =>
            {
                var newLines = TreeGenerator.GenerateTreeLines();
                lock (lines)
                {
                    lines.Clear();
                    lines.AddRange(newLines);
                }
            };
            
            while (true)
            {
                // 1. uruchamiamy wątek w tle, niech sobie generuje
                var thread = new Thread(job);
                thread.Start();
                
                // w tym samym czasie wyświetlamy zawartość poprzednią
                // (za 1 razem będzie pusta)
                // no chyba że wątek już się wyrobił z nadpisaniem
                // oba mają lock
                Console.Clear();
                lock(lines)
                    lines.ForEach(WriteColorfulLine);
                
                // czekamy trochę żeby nie wyświetlać za szybko
                Thread.Sleep(300);
                
                // czekamy na tamten wątek, ale w te 300ms to i tak
                // już dawno skończył
                thread.Join();
            }
        }

        public static void WriteColorfulLine(string text) {
            foreach(char c in text)
            {
                if (c == '*') Console.ForegroundColor = ConsoleColor.DarkGreen;
                else if (c == 'H') Console.ForegroundColor = ConsoleColor.DarkRed;
                else Console.ForegroundColor = GetRandomColor();
                
                Console.Write(c);
            }
            Console.WriteLine();
        }
        
        public static ConsoleColor GetRandomColor()
        {
            switch (Random.Next(7))
            {
                case 0:
                    return ConsoleColor.Red;
                case 1:
                    return ConsoleColor.Green;
                case 2:
                    return ConsoleColor.Blue;
                case 3:
                    return ConsoleColor.Yellow;
                case 4:
                    return ConsoleColor.Magenta;
                case 5:
                    return ConsoleColor.White;
                case 6:
                    return ConsoleColor.Cyan;
                default:
                    return ConsoleColor.Black;
            }
        }
    }

    // generator drzewa (sam kształt, bez kolorów)
    public static class TreeGenerator
    {
        private static readonly Random Random = new();
        
        /**
         * Generuje drzewo
         * Zwraca wynik w postaci listy linijek tekstu do wyswietlenia
         */
        public static List<string> GenerateTreeLines()
        {
            var treeLines = new List<string>();
            GenerateTreePart(ref treeLines, 1, 5, 6);
            GenerateTreePart(ref treeLines, 4, 8, 3);
            GenerateTreePart(ref treeLines, 7, 11);
            GenerateTreeStump(ref treeLines, 6, 3, 8);
            return treeLines;
        }
        
        private static char GetRandomCharacter(string choices = "****o~~.^")
        {
            int index = Random.Next(choices.Length);
            return choices[index];
        }
        
        private static void GenerateTreePart(ref List<string> lines, int from, int to, int initialPad = 0)
        {
            if (from > to) from = to;
            for (int i = from - 1; i <= to; i++)
            {
                StringBuilder branchLeft = new StringBuilder(i);
                StringBuilder branchRight = new StringBuilder(i);
                for (int k = 0; k < i; k++)
                {
                    branchLeft.Append(GetRandomCharacter());
                    branchRight.Append(GetRandomCharacter());
                }

                var str = new string(' ', to - i + initialPad) + branchLeft + '*' + branchRight;
                lines.Add(str);
            }
        }

        private static void GenerateTreeStump(ref List<string> lines, int width, int height, int pad)
        {
            var spaces = new string(' ', pad);
            var line = spaces + new string('H', width);
            for (var i = 0; i < height; i++)
            {
                lines.Add(line);
            }
        }
        
    }
}