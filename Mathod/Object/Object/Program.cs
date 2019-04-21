using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Student
    {
        public double calculateCGPA(double cSharp, double algo, double database)
        {
            return (cSharp * 4 + algo * 4 + database * 4) / 12;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Robi = new Student();
            double a = Robi.calculateCGPA(3.5, 3.7, 3.0);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
