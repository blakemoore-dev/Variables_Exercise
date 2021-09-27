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
            Console.WriteLine("I declared and initialized the following variables with included values:");
            Console.WriteLine($" myString: {myString},\n myInt: {myInt},\n myChar: {myChar},\n myBool: {myBool},\n myDouble: {myDouble},\n and myDecimal: {myDecimal}");
        }
    }
}
