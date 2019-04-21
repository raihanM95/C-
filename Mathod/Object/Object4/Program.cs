using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object4
{
    class Room
    {
        public double Length;
        public double Width;
        public double Depth;

        public Room(double L, double W, double D)
        {
            Length = L;
            Width = W;
            Depth = D;
        }

        public double CalcuateVolumn()
        {
            return Length * Width * Depth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Depth: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Room Box1 = new Room(a, b, c);

            double x = Box1.CalcuateVolumn();
            Console.WriteLine(x);

            Console.WriteLine("Enter Length: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Depth: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Room Box2 = new Room(d, e, f);

            double y = Box2.CalcuateVolumn();
            Console.WriteLine(y);

            Console.WriteLine("Enter Length: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Depth: ");
            double i = Convert.ToDouble(Console.ReadLine());
            Room Box3 = new Room(g, h, i);

            double z = Box3.CalcuateVolumn();
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
