﻿using System;

namespace Day_5_Basi_Programming_Practice_Problem
{
    internal class Program
    {
        public static void Main()
        {
            int year;
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else
                Console.WriteLine("{0} is not a leap year.\n", year);
        }
    }
    
}
