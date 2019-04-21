using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            string userInput1 = Console.ReadLine();
            Console.Write("Enter second number : ");
            string userInput2 = Console.ReadLine();
            int number1 = Convert.ToInt32(userInput1);
            int number2 = Convert.ToInt32(userInput2);
            int sum = number1 + number2;
            Console.WriteLine();
            Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, sum);
            Console.ReadLine();
        }
    }
}
