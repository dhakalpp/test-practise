using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            Console.WriteLine("Please enter a letter");
            string input = Console.ReadLine();
            switch (input)

            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                Console.WriteLine($"{input} is a vowel");
                break;
                default:
                Console.WriteLine($"{input} is a consonent");
                break;
              
                 
            }

            {
                Console.WriteLine("press enter to exit");
                Console.ReadLine();
            }

        }

       
    }
}
