using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20; int b = 10; int c = 15; int d = 5; int e;
            e = (a + b) * c / d;
            Console.WriteLine("Value of (a + b) * c / d is : {0}", e);
            e = ((a + b) * c) / d;
            Console.WriteLine("Value of ((a + b) * c) / d is : {0}", e);
            e = (a + b) * (c / d);
            Console.WriteLine("Value of (a + b) * (c / d) is : {0}", e);
            e = a + (b * c) / d;
            Console.WriteLine("Value of a + (b * c) / d is : {0}", e);
            Console.ReadLine();
        }
    }
}
