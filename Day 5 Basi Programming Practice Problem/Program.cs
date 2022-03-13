using System;

namespace Day_5_Basi_Programming_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;

            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            if (first > second)
            {
          
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
        }
    }
}
