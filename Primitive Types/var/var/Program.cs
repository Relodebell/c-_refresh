﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 23;
            Console.WriteLine(age);

            var bigNumber = 90000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.00000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "aba";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);
        }
    }
}
