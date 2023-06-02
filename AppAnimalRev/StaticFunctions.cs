using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev
{
    public abstract class StaticFunctions
    {
        public static double Promedio(params double[] valores)
        {
            double suma = 0.0;
            double prom = 0.0;
            int n = 0;

            for (n = 0; n < valores.Length; n++)
            {
                suma += valores[n];
            }
            prom = suma / valores.Length;
            return prom;
        }
    }
}
