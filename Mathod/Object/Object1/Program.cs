﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object1
{
    class Student
    {
        public string Id;
        public string Name;
        public double CGPA;

        public void calculateWaiver()
        {
            if(CGPA > 3.8)
            {
                Console.WriteLine("10% waiver");
            }
            else
            {
                Console.WriteLine("No waiver");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Alif = new Student();

            Alif.Id = "161-35-1542";
            Alif.Name = "Alif";
            Alif.CGPA = 4.00;
            Alif.calculateWaiver();

            Console.ReadLine();
        }
    }
}
