using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateTotal()
        {
            return _amount - (_amount * 0.10m);
        }
    }
}
