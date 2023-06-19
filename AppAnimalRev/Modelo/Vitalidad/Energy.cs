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
        private int _estado = 100;

        public int Estado()
        { return _estado; }

        public void Estado(int value)
        { _estado += value; }
    }
}
