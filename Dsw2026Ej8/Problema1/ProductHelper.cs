using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    internal partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return "[" + code + "] " + description + " - " + FormatearPrecio(price);
        }
    }
}
