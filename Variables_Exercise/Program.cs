using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1:  Declare and initialize variables for the following types:
            string myString = "Some text";
            int myInt = 10;
            char myChar = 'c';
            bool myBool = true;
            double myDouble = 20.2;
            decimal myDecimal = 300.003m;

            // Step 2:  Interpolate these variables in a Console.WriteLine():
            Console.WriteLine($"myString : {myString}");
            Console.WriteLine($"myInt : {myInt}");
            Console.WriteLine($"myChar : {myChar}");
            Console.WriteLine($"myBool : {myBool}");
            Console.WriteLine($"myDouble : {myDouble}");
            Console.WriteLine($"myDecimal : {myDecimal}");
        }
    }
}
