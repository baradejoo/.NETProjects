using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja6
{
    class Program
    {
        class Stack<T> where T : IComparable 
        {
            private int count = 0;
            private class StackItem
            {
                public T value;
                public StackItem prev;

                public StackItem(T value)
                {
                    this.value = value;
                }
            }
            private StackItem topItem;

            public int Count => count;
            public bool IsEmpty => count == 0;

            public int ShowTheNumberOfItems() => Count;

            public void AddItem(T newItem)
            {
                var entry = new StackItem(newItem);
                entry.prev = topItem;
                topItem = entry;
                count++;
            }

            public T Pop()
            {
                var it = topItem;
                if (it != null)
                {
                    topItem = it.prev;
                }

                count--;
                Debug.Assert(it != null, nameof(it) + " != null");
                return it.value;
            }

    

    

       
            public int FindAnItem(T value)
            {
                var current = topItem;
                var i = 0;
                while (current != null)
                {
                    if (current.value.Equals(value)) return Count - i;
                    current = current.prev;
                    i++;
                }

                return -1;
            }
            public void PrintAllItems()
            {
                var current = topItem;
                while (current != null)
                {
                    Console.WriteLine(current.value);
                    current = current.prev;
                }
            }

        }
        static void Main(string[] args)
        {
 
            var rnd = new Random();
            var stack1 = new Stack<int>();
            var stack2 = new Stack<int>();
            for (var i = 0; i < 100; i++)
            {
                // ograniczylem max wartosc do 30 zeby byly powtorzenia
                stack1.AddItem(rnd.Next(30));
                stack2.AddItem(rnd.Next(30));
            }

            var stack3 = new Stack<int>();
            while (!stack1.IsEmpty)
            {
                var value = stack1.Pop();
                if (value % 2 == 0 && stack3.FindAnItem(value) == -1)
                    stack3.AddItem(value);
            }
            while (!stack2.IsEmpty)
            {
                var value = stack2.Pop();
                if (value % 2 == 0 && stack3.FindAnItem(value) == -1)
                    stack3.AddItem(value);
            }
            Console.WriteLine("\nThird stack contents:");
            stack3.PrintAllItems();
        }
    }
}