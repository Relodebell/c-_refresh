using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the time in the 24 hour format: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour >= 0 && hour <= 5)
            {
                Console.WriteLine("It's Dawn.");
            }
            else if (hour >= 6 && hour <= 11)
            {
                Console.WriteLine("It's Morning");
            }
            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("It's Afternoon");
            }
            else if (hour >= 18 && hour <= 23)
            {
                Console.WriteLine("It's Evening");
            }
            else
            {
                Console.WriteLine("Wrong time. 0-23 only");
            }

            Console.ReadLine();
        }
    }
}
