using System;
using System.IO;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
        // Using Object Type 
           Console.WriteLine("Using object Type");   
           object height = 1.88; // storing a double in a object
           object name = "Amir"; // storitng a string in an object
           Console.WriteLine($"{name} is {height} metres tall ");
           // int length1 = name.Length; // Gives comile error!
           int length2 = ((string)name).Length; // tell compler it is string
           Console.WriteLine($"{name} has {length2} characters.");

           // Using Dynamic Type
           Console.WriteLine("Using Dynamic Type");
           // storing a string in a dynamic object
           dynamic anotherName = "Ahmed";
           // This compiles but would throw an exception at run time
           // if you later store a data type that does not have a
           // property named Length
           int length = anotherName.Length;  // Intellisense cannot detect the "Length" in VS Code intellisence
           Console.WriteLine(length);

           //Specifying and inferring the type of a local variable
           Console.WriteLine("\nSpecifying and inferring the type of a local variable");
           var population = 66_000_000; //66 Milliion in UK
           var weight = 1.88; // Weight in Kilograms
           var price = 4.99M; // in pounds sterling
           var fruit = "Apples"; // strings use double quotes
           var letter = 'Z'; // chars use single - quotes
           var happy = true; // Booleans have value of True or False
           
           // Good use of var becasue it avoids the repeated type
           // As shown in the more verbose second statement
           Console.WriteLine("\nGood use of var becasue it avoids the repeated type");
           var xml1 = new XmlDocument();
           XmlDocument xml2 = new XmlDocument();

           // bad use of var because we cannot tell the type, so we
           // should use a specific type declaration as shown in
           // the second statement  
           Console.WriteLine("bad use of var because we cannot tell the type");
           var file1 = File.CreateText(@"C:\temp\something.txt");
           file1.Close();
           StreamWriter file2 = File.CreateText(@"C:\temp\something.txt");
           file2.Close();

           // Using target-typed new to instantiate objects
           XmlDocument xml3 = new(); // target-typed new in C# 9

           // Print Default values
           Console.WriteLine("\nPrint Default values of Types");
           Console.WriteLine($"default(int) = {default(int)}");
           Console.WriteLine($"default(bool) = {default(bool)}");
           Console.WriteLine($"default(DateTime) = {default(DateTime)}");
           Console.WriteLine($"default(string) = {default(string)}");

        }
    }
}
