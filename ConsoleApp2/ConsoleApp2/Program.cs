using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 2");
            Console.WriteLine("please calculate your BMI");
            Console.WriteLine("what is your weight in kg's: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("can you please enter your heigh in CM'S: ");
            float height = float.Parse(Console.ReadLine())/100;
            Console.WriteLine("your BMI is: " +(weight / (height*height))) ;

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
