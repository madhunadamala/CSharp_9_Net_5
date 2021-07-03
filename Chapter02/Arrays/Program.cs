﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names; // Can reference any array of strings
            
            //allocating memory for four strings in an array
            names = new string[4];

            //storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebeca";
            names[3] = "Tom";

            // Looping through the names
            for(int i = 0; i<names.Length; i++)
            {
                // Output the item at index postion i
                Console.WriteLine(names[i]);
            }
        }
    }
}
