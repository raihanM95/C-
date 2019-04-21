using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while(a < 20)
            {
                Console.WriteLine("Value of a: {0}", a);
                a++;
                if(a > 15)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
