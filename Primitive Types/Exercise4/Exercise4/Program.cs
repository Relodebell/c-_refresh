using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 11;
            int second = 2;

            int remainder = first % second;

            Console.WriteLine(remainder);

            first = 12;
            remainder = first % second;
            Console.WriteLine(remainder);
            
            Console.ReadLine();
        }
    }
}
