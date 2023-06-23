
using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimal.Modelo.Concretas
{
    public class Acuatic : IAcuatic
    {
        public void Move(Energy energia, Position posicion)
        {
            throw new System.NotImplementedException();
        }
        // usar strategy con move() para que quede dentro de otro metodo mas especifico

        public void Swim(Energy energia, Position posicion)
        {
            throw new System.NotImplementedException();
        }
    }
}

