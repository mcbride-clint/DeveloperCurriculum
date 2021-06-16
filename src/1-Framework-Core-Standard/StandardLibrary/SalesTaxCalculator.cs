using System;

namespace StandardLibrary
{
    public class SalesTaxCalculator
    {
        public decimal CalculateTax(decimal totalPrice)
        {
            return totalPrice * 0.7m;
        }
    }
}
