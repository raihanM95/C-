using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            for(a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("Value of a: {0}", a);
            }
            Console.ReadLine();
        }
    }
}
