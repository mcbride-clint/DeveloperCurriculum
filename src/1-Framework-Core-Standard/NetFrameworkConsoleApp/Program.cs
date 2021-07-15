using StandardLibrary;
using System;

namespace NetFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal itemPrice = 12.99m; // Declare price variable

            var taxCalculator = new PaSalesTaxCalculator(); // Create a new instance of Sales Tax Calculator 

            var salesTax = taxCalculator.CalculateTax(itemPrice); // Claculate the sales tax

            Console.WriteLine($"Total Cost is $ {string.Format("{0:0.##}", salesTax + itemPrice)}"); // Output the total price formatted as a currency

            Console.WriteLine("Press any key to exit"); // Keep screen open so developer can read output
            _ = Console.ReadKey();
        }
    }
}
