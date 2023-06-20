using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev
{
    public static class Enums
    {
        public enum TipoCreacion { Animalia, Plantae, Fungi, Protista, Monera, ComidaOrigenAnimal, ComidaOrigenVegetal }
        public enum TipoComida { Animalia, Plantae}

        public enum Kingdom { Animalia, Plantae, Fungi, Protista, Monera, Comida };

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
