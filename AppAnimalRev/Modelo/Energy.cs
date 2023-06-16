using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev.Modelo.Abstractas.No
{
    public class Energy
    {
        private int _estado = 100;

        public int Estado { get => _estado; set => _estado = value; }

        protected void RecargarEnergia()
        {

        }
    }
}
