using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true; bool b = true;
            if (a && b)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }
            a = false; b = true;
            if (a && b)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is not true");
            }
            if (!(a && b))
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
            Console.ReadLine();
        }
    }
}
