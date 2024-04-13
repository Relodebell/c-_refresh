using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            //int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            // || = or, && = and
            if (age <0 || age > 150)
            {
                Console.WriteLine("Invalid age.");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are 18-25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are older than 26");
                }
            }
            */

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            int actualAnswer = Convert.ToInt32(Console.ReadLine());

            if (actualAnswer == answer) {
                Console.WriteLine("Correct.");
            }
            else 
            { 
                Console.WriteLine("Wrong.");
            }

            Console.ReadLine();
        }
    }
}
