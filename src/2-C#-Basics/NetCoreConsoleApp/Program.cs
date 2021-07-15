using StandardLibrary;
using System;

namespace NetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProceduralCodeSalesTaxCalculation();
            ClassBasedSalesTaxCalculation();
        }

        static void ProceduralCodeSalesTaxCalculation()
        {
            decimal itemPrice = 12.99m; // Declare price variable
            string county = "Allegheny";

            // Lookup our county to determin the tax rate
            var taxRate = county switch
            {
                "Allegheny" => .07m,
                "Westmoreland" => .06m,
                _ => .06m,
            };

            var salesTax = itemPrice * taxRate; // Calculate the sales tax

            Console.WriteLine($"Bad Code: Total Cost is $ {string.Format("{0:0.00}", salesTax + itemPrice)}"); // Output the total price formatted as a currency
        }

        static void ClassBasedSalesTaxCalculation()
        {
            decimal itemPrice = 12.99m; // Declare price variable
            County county = County.Westmoreland;

            var calcuatorProvider = new SalesTaxCalculatorProvider();
            ICalculateSalesTax calculator = calcuatorProvider.LoopkUp(county);

            var salesTax = calculator.CalculateTax(itemPrice); // Calculate the sales tax

            Console.WriteLine($"Class Based Code: Total Cost is $ {string.Format("{0:0.00}", salesTax + itemPrice)}"); // Output the total price formatted as a currency

        }
    }
}
