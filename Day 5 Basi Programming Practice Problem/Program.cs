using System;

namespace Day_5_Basi_Programming_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend , divisor ;
            Console.WriteLine("Enter a Dividend of Number : ");
            dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Divisor of Number : ");
            divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
