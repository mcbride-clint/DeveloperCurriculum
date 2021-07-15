using StandardLibrary;
using System;

namespace NetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal itemPrice = 12.99m; // Declare price variable

            var taxCalculator = new PaSalesTaxCalculator(); // Create a new instance of Sales Tax Calculator 

            var salesTax = taxCalculator.CalculateTax(itemPrice); // Calculate the sales tax

            Console.WriteLine($"Total Cost is $ {string.Format("{0:0.00}", salesTax + itemPrice)}"); // Output the total price formatted as a currency
        }
    }
}
