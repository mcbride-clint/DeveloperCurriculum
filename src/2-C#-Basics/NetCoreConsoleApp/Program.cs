using StandardLibrary;
using System;

namespace NetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal itemPrice;

            Console.WriteLine("Please enter the item price:");
            while (decimal.TryParse(Console.ReadLine(), out itemPrice) == false){
                Console.WriteLine("Not a valid price. Please enter a price:");
            }

            ProceduralCodeSalesTaxCalculation(itemPrice);
            ClassBasedSalesTaxCalculation(itemPrice);
        }

        static void ProceduralCodeSalesTaxCalculation(decimal itemPrice)
        {
            string county = "Allegheny";

            // Lookup our county to determin the tax rate
            var taxRate = county switch
            {
                "Allegheny" => .07m,
                "Westmoreland" => .06m,
                _ => .06m,
            };

            var salesTax = itemPrice * taxRate; // Calculate the sales tax

            Console.WriteLine($"Procedural Code: Total Cost is $ {string.Format("{0:0.00}", salesTax + itemPrice)}"); // Output the total price formatted as a currency
        }

        static void ClassBasedSalesTaxCalculation(decimal itemPrice)
        {
            PaCounty county = PaCounty.Allegheny; // Set County

            var calcuatorProvider = new PaSalesTaxCalculatorProvider();
            ICalculateSalesTax calculator = calcuatorProvider.LoopkUp(county);

            var salesTax = calculator.CalculateTax(itemPrice); // Calculate the sales tax

            Console.WriteLine($"Class Based Code: Total Cost is $ {string.Format("{0:0.00}", salesTax + itemPrice)}"); // Output the total price formatted as a currency
        }
    }
}
