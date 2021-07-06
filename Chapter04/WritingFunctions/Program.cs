using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            RunsTimesTable();
            WriteLine ("\nCaluclating Tax");
            RunCalculateTax();
        }
        #region TimesTable
        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is {number} times table");
            for (int row = 0; row <= 12; row ++)
            {
                WriteLine($"{row} X {number} = {row * number} ");
            }   
            WriteLine();
        }
        #endregion TimesTable

        #region RunsTimesTable
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
        #endregion RunsTimesTable

        #region RunCalculateTax

       
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch(twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "DK": // Denmark
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // United Kingdon
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "OR": // Oregon 
                case "AK": // Alaska 
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota 
                case "WI": // Wisconsin 
                case "ME": // Maryland 
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                        rate = 0.0825M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break; 
            }
            return amount * rate;
        }
       
        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountIntext = ReadLine();

            Write("Enter a  two-letter region code: ");
            string region = ReadLine();
            
            if (decimal.TryParse(amountIntext, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in Sales Tax");
            }
            else
            {
                WriteLine("You did no enter valid amount!");
            }
            
        }

        #endregion RunCalculateTax
    }
}
