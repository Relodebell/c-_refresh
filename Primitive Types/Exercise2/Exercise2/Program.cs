using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 10;
            int num3 = 15;

            int numsum = num1 + num2 + num3;
            double average = Convert.ToDouble(numsum)/3;
            Console.WriteLine(numsum);
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
