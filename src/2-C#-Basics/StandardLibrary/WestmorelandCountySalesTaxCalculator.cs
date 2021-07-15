namespace StandardLibrary
{
    /// <summary>
    /// Handles Pa Sales Tax Calculations
    /// </summary>
    public class WestmorelandCountySalesTaxCalculator : SalesTaxCalculator
    {
        public WestmorelandCountySalesTaxCalculator() : base(0.06m) { }
    }
}
