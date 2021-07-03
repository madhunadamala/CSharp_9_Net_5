using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine(
            $"{decimalNotation == hexadecimalNotation}");

            // Writing code to explore number Sizes
            Console.WriteLine("\nWriting code to explore number Sizes");
            Console.WriteLine($"int use {sizeof(int)} bytes and can store "+
                $" numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0} ");
            
            Console.WriteLine($"\ndouble uses {sizeof(double)} bytes and can store "+
                $" numbers in the range of \n {double.MinValue:N0} TO \n {double.MaxValue:N0} ");

            Console.WriteLine($"\ndecimal uses {sizeof(decimal)} bytes and can store "+
                $" numbers in the range of \n {decimal.MinValue:N0} TO \n {decimal.MaxValue:N0} ");
            
            Console.WriteLine("\nUsing Dobules:");
            double a = 0.1;
            double b = 0.2;

            if (a+b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals to 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equals to 0.3");
            }

             Console.WriteLine("\nUsing Decimals:");
            decimal c = 0.1M; // M Suffix means a decimal literal value.
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals to 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equals to 0.3");
            }

        }
    }
}
