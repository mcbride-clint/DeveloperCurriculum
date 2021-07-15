using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public interface ICalculateSalesTax
    {
        decimal CalculateTax(decimal itemPrice);
    }
}
