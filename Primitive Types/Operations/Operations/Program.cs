using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 23;
            // + - * /
            age /= 10;

            Console.WriteLine(age);

            string name = "Aba";
            name += " is programming!";

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            Console.WriteLine(name);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
