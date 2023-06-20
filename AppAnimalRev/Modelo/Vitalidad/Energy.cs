using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev.Modelo.Vitalidad
{
    public class Energy
    {
        private int _estado; 

        public Energy()
        {
            _estado = 100;
        }

        public int getEstado()
        { return _estado; }

        public void setEstado(int value)
        { _estado += value; }
    }
}
