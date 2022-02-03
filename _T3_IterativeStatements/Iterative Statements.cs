// Daniel Pereira U96565982
// T3 Using Iterative Statements

using System;

namespace _T3_IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // User enters input for program
            Console.Write("Please enter an increment value between 5 and 25 that will be used to increment the CAD values in the table below...");

            // Try catch block in place to handle exceptions in user input
            try

            {
                // Input from user is converted into a usable variable
                string input = Console.ReadLine(); // Variable made to store user input as string
                int incrementValue = int.Parse(input); // Variable made to store user input as decimal

                // Extra variables needed
                decimal canadaDollar = 0m; // Canadian dollar variable
                decimal USdollar = 0m; // US dollar variable
                decimal conversionFactor = 0.792367m; // Conversion number variable

                // test input to see if value is between 5 and 25
                if ((incrementValue >= 5) && (incrementValue <= 25))
                {
                    // Write text below as header in console
                    Console.WriteLine("CAD increment value = 0.792367");
                    Console.WriteLine();
                    Console.WriteLine("CAD" + "      " + "$US");
                    Console.WriteLine();

                    // while loop to show table using conversion number and user input
                    while (canadaDollar <= 200)
                    {
                        Console.WriteLine("$" + canadaDollar.ToString() + "      $" + USdollar.ToString());
                        canadaDollar = (canadaDollar + incrementValue);
                        USdollar = decimal.Multiply(canadaDollar, conversionFactor);
                    }
                }
                else
                {
                    Console.WriteLine("Number entered is not in the correct range between 5 and 25, please try again.");
                }
            }

            // Try catch block in place to handle exceptions in user input
            catch
            {
                Console.WriteLine("The input entered is not a valid number. Please try again.");
            }
        }
    }
}