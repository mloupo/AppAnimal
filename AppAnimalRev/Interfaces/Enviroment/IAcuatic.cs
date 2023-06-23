using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Interfaces.Enviroment
{
    interface IAcuatic : IEnviroment
    {
        void Swim(Energy energia, Position posicion);
    }
}
