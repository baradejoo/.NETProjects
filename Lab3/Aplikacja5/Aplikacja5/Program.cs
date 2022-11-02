using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja5
{
    
    internal class Program
    {

        static string getcharName(string char_) =>
            "aeiouAEIOU".Contains(char.Parse(char_)) ? "samogloska" :
            int.TryParse(char_, out int p) ? "cyfra" :
                "Inne";
        static void Main(string[] args)
        {
            string string_ = Console.ReadLine();
            var x = getcharName(string_);
            Console.WriteLine($"Char is {x}");

        }
    }
}
