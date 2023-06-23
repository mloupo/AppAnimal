using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Interfaces.Enviroment
{
    interface IAereal : IEnviroment
    {
        void Fly(Energy energia, Position posicion);

    }
}