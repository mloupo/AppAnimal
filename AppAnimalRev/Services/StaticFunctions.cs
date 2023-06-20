using AppAnimal.Modelo.Posicion;
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
        protected Position setPosition(Position posicion, int x, int y)
        {
            //Aca estaria bueno que se guarde la posicion anterior en variables privadas del objeto.
            //Para poder volver a la posicion inmediata anterior
            posicion.X = x;
            posicion.Y = y;
            return posicion;
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
    }
}
