using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimal.Modelo.Abstractas.No
{
    public class Specie
    {
        private string name = String.Empty;

        public Specie() { }

        protected string Name { get => name; set => name = value; }
    }
}
