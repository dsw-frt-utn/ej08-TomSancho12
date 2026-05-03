using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema4
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            if (nota1 != null && nota1>=0 && nota1 <= 10)
            {
                suma = suma + nota1.Value;
                cantidad++;
            }
            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma = suma + nota2.Value;
                cantidad++;
            }
            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma = suma + nota3.Value;
                cantidad++;
            }
            if (cantidad == 0)
            {
                return 0;
            }

            return (double)suma / cantidad;

        }
    }
}
