using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimal.Modelo.Concretas
{
    public class Aereal : IAereal
    {
        public void Fly(Energy energia, Position posicion)
        {
            throw new NotImplementedException();
        }

        public void Move(Energy energia, Position posicion)
        {
            throw new NotImplementedException();
        }
    }
}
