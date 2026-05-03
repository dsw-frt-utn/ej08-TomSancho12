using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Dsw2026Ej8.Domain;

namespace Dsw2026Ej8.Problema3
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;

            Product ProductoCopia = product;
            ProductoCopia.Update(ProductoCopia.GetDescription() + " (copia)");

            return originalValue + "-" + copia + "-" + product.GetDescription();
        }
    }
}
