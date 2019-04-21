using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object3
{
    class Room
    {
        public double Length;
        public double Width;
        public double Depth;

        public void SetValus(double L, double W, Double D)
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
            Room Box1 = new Room();
            Box1.SetValus(4.4, 4.2, 4.0);

            double a = Box1.CalcuateVolumn();
            Console.WriteLine(a);

            Room Box2 = new Room();
            Box2.SetValus(5.4, 5.2, 5.0);

            double b = Box2.CalcuateVolumn();
            Console.WriteLine(b);

            Room Box3 = new Room();
            Box3.SetValus(6.4, 6.2, 6.0);

            double c = Box3.CalcuateVolumn();
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
