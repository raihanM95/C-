using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Customer
    {
        public string Id;
        public string Name;
        public string Membership;
        public double Bill;

        public Customer(string I, string N, string M, double B)
        {
            Id = I;
            Name = N;
            Membership = M;
            Bill = B;
        }

        public double checkTax()
        {
            return (Bill * 102) / 100;
        }

        public double checkMembership()
        {
            if (Membership == "Gold")
            {
                return checkTax() * 0.1;
            }
            else if (Membership == "Silver")
            {
                return checkTax() * 0.04;
            }
            else
            {
                return 0;
            }
        }

        public double calculateTotalbill()
        {
            return Bill - checkMembership();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("161", "Alom", "Gold", 5850);
            double z = customer.calculateTotalbill();
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
