using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a < 20)
            {
                Console.WriteLine("Value of a: {0}", a);
                a++;
            }
            Console.ReadLine();
        }
    }
}
