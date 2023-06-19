using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev.Services
{
    public abstract class StaticFunctions
    {
        private static int _energy;

        public static void setEnergyPlus(int energy) // Metodo generico para aumentar la energia de cualquier animal independientemente de como la obtenga
        {
            _energy += energy;
            if (_energy >= 100)
            {
                _energy = 100;
            }
        }
        public static void setEnergyLess(int energy) // Metodo generico para reducir la energia de cualquier animal independientemente de como la gaste
        {
            _energy -= energy;
            if (_energy <= 0)
            {
                _energy = 0;
            }
        }

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

        /*public void static btnDetecta_Click(object sender, EventArgs e)
      
        
           double prome = Promedio( 27, 9, 18);
         Console.WriteLine("El promedio es: " + prome);

         Console.WriteLine(char.IsDigit('.'));

         for (int i = 0, j = 5; i < 6; i++, j--)
         {
             Console.WriteLine("i={0}, j={1}", i, j);
         }
         Console.ReadLine();*/
    }
}
