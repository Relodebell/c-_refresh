using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            char letter = '\0'; 
            // \0 is default, char needs to have a character, string doesn't.

            Console.Write("Your name is : ");
            Console.Write(name);

            Console.WriteLine();
            Console.WriteLine(letter);


            Console.ReadLine();
        }
    }
}
