﻿using System;

namespace NullHandling
{
    // It enables nullable on this class. Setting required in the Project file.
    #nullable enable

    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
          //  thisCannotBeNull = null;   // Compilation error!
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            // Using the Nullable reference type.
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            //Check that the variable is not null before using it
            if(thisCouldBeNull != null)
            {
                //access a member of thisCouldBeNull
             //   int length = thisCouldBeNull.Length // could throw exception
               
            }

            // Instead of throwing an exception, null is assigned to y
            string authorName = null;
            int? y = authorName?.Length;
            Console.WriteLine(y);

            // result will be 3 if authorName?.Length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);

        }
    }
}
