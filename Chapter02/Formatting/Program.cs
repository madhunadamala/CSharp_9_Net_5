﻿using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(format:"{0} apples costs {1:C}", arg0:numberOfApples, arg1:pricePerApple * numberOfApples);
            // Storing the formatted value to a vairable.
            string formatted = string.Format(format:"{0} apples costs {1:C}", 
                arg0:numberOfApples, arg1:pricePerApple * numberOfApples);

            // String interpolation from C# 6.0
            Console.WriteLine("\nString Interpolation example");
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // Text alignement. Syntax: { index [, alignment ] [ : formatString ] }
            Console.WriteLine("\nText alignment");
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            Console.WriteLine(format:"{0,-8}{1,6:N0}",arg0: "Name", arg1: "Count");
            Console.WriteLine(format: "{0,-8}{1,6:N0}", arg0: applesText, arg1: applesCount);
            Console.WriteLine(format: "{0,-8}{1,6:N0}", arg0: bananasText, arg1: bananasCount);
        }
    }
}
