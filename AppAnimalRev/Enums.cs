using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev
{
    public static class Enums
    {
        public enum TipoCreacion { Animal, Planta, Comida }
        public enum Kingdom { Animalia, Plantae, Fungi, Protista, Monera };

        [Flags]
        //public enum Condimentos { nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8 }
        public enum Condimentos 
        { 
            nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8,
            Basica = Tomate | Lechuga,
            Completa = Tomate | Lechuga | Cebolla | Queso
        }
    }
}
