using AppAnimalRev;
using AppAnimalRev.Interfaces.Enviroment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimal.Modelo.Abstractas 
{ 
    public abstract class Organic : Thing
    {
        protected string Species = String.Empty;
        protected IEnviroment enviroment;
        public Organic() { }
    }
}
