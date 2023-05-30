using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimal.Modelo.Abstractas.No
{
    public abstract class Organic
    {
        public Specie Especie { get; set; }

        public Organic()
        {
            Especie = new Specie();
        }
    }
}
