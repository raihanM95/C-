using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Parking
    {
        public string CarNo;
        public string Shift;
        public double parkingHour;

        public Parking(string C, string S, double H)
        {
            CarNo = C;
            Shift = S;
            parkingHour = H;
        }

        public double calculateParkingFee()
        {
            if(Shift == "Day")
            {
                return parkingHour * 20;
            }
            else if(Shift == "Night")
            {
                return parkingHour * 30;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parking P1 = new Parking("kha-34539L", "Day", 4);
            double x = P1.calculateParkingFee();
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
