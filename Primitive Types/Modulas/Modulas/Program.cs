using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulas
{
    class Program
    {
        /// <summary>
        /// Modulas
        /// </summary>
        /// <param name="args">For future use</param>
        static void Main(string[] args)
        {
            int firstnum = 10;
            int secondnum = 3;

            /* 10/3 = 3r1, 
             * 3 x 3 = 9, 1 left over to get to 10
             * 10 % 2 = 0 
             * 11 % 2 = 1 
            */

            Console.WriteLine((firstnum % secondnum));

            Console.WriteLine();

            Console.ReadLine(); 
        }
    }
}
