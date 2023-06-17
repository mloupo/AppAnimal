using AppAnimalRev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimal.Modelo.Abstractas.No
{
    public abstract class Organic : Thing
    {
        protected string Species = String.Empty;
        public Organic() { }
    }
}
