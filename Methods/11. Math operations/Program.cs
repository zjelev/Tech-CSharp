﻿using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a, @operator, b)); 
        }

        static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = (double)a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
