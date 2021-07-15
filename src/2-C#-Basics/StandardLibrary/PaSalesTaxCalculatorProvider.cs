using System;

namespace StandardLibrary
{
    /// <summary>
    /// Provides a Sales Tax Calculator for Pennsylvania
    /// </summary>
    public class PaSalesTaxCalculatorProvider
    {
        /// <summary>
        /// Provides a Sales Tax Calclator given a County in Pennsylvania
        /// </summary>
        /// <param name="county"></param>
        /// <returns>Instance of ICalculateSalesTax</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public ICalculateSalesTax LoopkUp(PaCounty county)
        {
            switch (county)
            {
                case PaCounty.Allegheny:
                    return new AlleghenyCountySalesTaxCalculator();
                case PaCounty.Westmoreland:
                    return new WestmorelandCountySalesTaxCalculator();
                default:
                    throw new ArgumentOutOfRangeException(nameof(county),
                        $"Selected County: [{county}] is not yet supported by the {nameof(PaSalesTaxCalculatorProvider)}");
            }
        }
    }
}