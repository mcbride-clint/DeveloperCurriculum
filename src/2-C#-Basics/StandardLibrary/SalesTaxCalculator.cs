namespace StandardLibrary
{
    public abstract class SalesTaxCalculator : ICalculateSalesTax
    {
        public SalesTaxCalculator(decimal taxRate)
        {
            _taxRate = taxRate;
        }

        public decimal _taxRate;
        public decimal TaxRate { get => _taxRate; }


        /// <summary>
        /// Returns the tax needed for the product
        /// </summary>
        /// <param name="itemPrice"></param>
        /// <returns></returns>
        public decimal CalculateTax(decimal itemPrice)
        {
            return itemPrice * TaxRate;
        }
    }
}