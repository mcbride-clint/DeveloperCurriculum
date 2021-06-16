using StandardLibrary;
using System;

namespace NetFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalPrice = 12.99m;

            var taxCalculator = new SalesTaxCalculator();

            var salesTax = taxCalculator.CalculateTax(totalPrice);

            Console.WriteLine($"Total Cost is $ {string.Format("{0:0.##}", salesTax + totalPrice)}");

            Console.WriteLine("Press any key to exit");
            _ = Console.ReadKey();
        }
    }
}
