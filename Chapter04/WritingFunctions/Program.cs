using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            RunsTimesTable();
        }

        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is {number} times table");
            for (int row = 0; row <= 12; row ++)
            {
                WriteLine($"{row} X {number} = {row * number} ");
            }   
            WriteLine();
        }

        static void RunsTimesTable()
        {
            bool isNumber;
            do{
                WriteLine("Enter a number between 0 and 255");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if(isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number, Process Exit");
                }
            }
            while(isNumber);
        }
    }
}
