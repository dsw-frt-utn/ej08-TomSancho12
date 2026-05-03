using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal class Sale
    {
        protected decimal _amount;

        public Sale(decimal amount)
        {
            _amount = amount;
        }

        public virtual decimal CalculateTotal()
        {
            return _amount;
        }
    }
}
