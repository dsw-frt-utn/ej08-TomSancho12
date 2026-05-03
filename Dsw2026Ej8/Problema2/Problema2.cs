using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema2
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;

            if (quantity <= 0)
            {
                total = 0;
            }
            else
            {
                total = quantity * unitPrice;
            }

            var venta = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            return venta.Code + "-" + venta.Description + "-" + venta.Total.ToString("C");
        }
    }
}
