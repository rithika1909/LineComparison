﻿using System;
namespace LineComparison
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Operation operation1 = new Operation(2, 1, 4, 3);
            Operation operation2 = new Operation(6, 4, 2, 3);
            double line1= operation1.CalculateLength();
            double line2 = operation2 .CalculateLength(); 
            if (line1.Equals(line2))
                Console.WriteLine("Line1 and Line2 are equal");
            else
                Console.WriteLine("Line1 and Line2 are not equal");
        }
    }

}

