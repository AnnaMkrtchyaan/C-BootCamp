using System;

namespace Anna_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

             
            //Console.Write("Enter first number:");
            //double an = double.Parse(Console.ReadLine());
            //Console.Write("Enter second number:");
            //double na = double.Parse(Console.ReadLine());
            //double sum = an + na;
            //double deduction = an - na;
            //double division = an / na;
            //double multiplication = an * na;
            //double residual_division = an % na;
            //Console.WriteLine("Sum=" + sum);
            //Console.WriteLine("Deduction=" + deduction);
            //Console.WriteLine("Multiplication=" + multiplication);
            //Console.WriteLine("Residual division=" + residual_division);

            //Console.Write("Enter your birth number:");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //  int old = 2023 - number;
            //    Console.WriteLine("You're " + old + " years old:");
            //}
            //else Console.WriteLine("ERROR");

            Console.Write("Enter 1 number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2 number:");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            if (a > 1 && b < 0)
            {
                 sum = a + b;
            }
            else sum = a * a + b * b;
            Console.WriteLine("Sum=" + sum);

        }
    }
}
