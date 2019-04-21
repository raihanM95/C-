
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                writetext.WriteLine("writing in text file");
                string a = Console.ReadLine();
                writetext.WriteLine(a);

            }

            try
            {
                using (StreamReader readtext = new StreamReader("write.txt"))
                {
                    string readMeText;
                    while ((readMeText = readtext.ReadLine()) != null)
                    {
                        Console.WriteLine(readMeText);
                    }
                    readtext.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
