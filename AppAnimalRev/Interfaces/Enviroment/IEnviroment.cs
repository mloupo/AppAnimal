using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Interfaces.Enviroment
{
    public interface IEnviroment
    {
        void Move(Energy energia, Position posicion);
    }
}
