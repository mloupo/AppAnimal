

using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Modelo.Kingdom;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Interfaces
{
    public interface IAnimal
    {
        void Eat(IFood Comida);
        void Move(Energy energia, Position posicion); // (energy-30), (CoordinatesNewPosition(x,y))
        void Sleep(Energy energia); // (energy + 50)


    }
}
