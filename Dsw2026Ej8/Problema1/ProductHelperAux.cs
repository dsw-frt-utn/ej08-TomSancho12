using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    internal partial class ProductHelper
    {
        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}