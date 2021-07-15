namespace StandardLibrary
{
    /// <summary>
    /// Classes that Implement this will have a these function(s) to be able to Calculate Sales Tax
    /// </summary>
    public interface ICalculateSalesTax
    {
        /// <summary>
        /// Calculate a sales tax given an item price
        /// </summary>
        /// <param name="itemPrice">Price of an Item</param>
        /// <returns>decimal</returns>
        decimal CalculateTax(decimal itemPrice);
    }
}
