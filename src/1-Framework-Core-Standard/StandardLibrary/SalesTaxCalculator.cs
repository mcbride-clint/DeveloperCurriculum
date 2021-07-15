namespace StandardLibrary
{
    /// <summary>
    /// Handles Pa Sales Tax Calculations
    /// </summary>
    public class PaSalesTaxCalculator
    {
        /// <summary>
        /// Constant Tax Rate
        /// </summary>
        private readonly decimal _taxRate = 0.07m;

        /// <summary>
        /// Returns the tax needed for the product
        /// </summary>
        /// <param name="totalPrice"></param>
        /// <returns></returns>
        public decimal CalculateTax(decimal totalPrice)
        {
            return totalPrice * _taxRate;
        }
    }
}
