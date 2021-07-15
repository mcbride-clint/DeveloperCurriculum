using System;

namespace StandardLibrary
{
    public class SalesTaxCalculatorProvider
    {
        public ICalculateSalesTax LoopkUp(County county)
        {
            switch (county)
            {
                case County.Allegheny:
                    return new AlleghenyCountySalesTaxCalculator();
                case County.Westmoreland:
                    return new WestmorelandCountySalesTaxCalculator();
                default:
                    throw new ArgumentOutOfRangeException(nameof(county),
                        $"Selected County: [{county}] is not yet supported by the {nameof(SalesTaxCalculatorProvider)}");
            }
        }
    }
}