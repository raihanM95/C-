using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            do
            {
                if (a == 6)
                {
                    //a = a + 1;
                    break;
                }
                Console.WriteLine("Value of a: {0}", a);
                a++;
            }
            while (a < 6);
            Console.ReadLine();
        }
    }
}
