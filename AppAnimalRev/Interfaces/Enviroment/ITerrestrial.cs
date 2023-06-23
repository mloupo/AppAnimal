using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Interfaces.Enviroment
{
    interface ITerrestrial : IEnviroment
    {
        void Crawl(Energy energia, Position posicion);
        void Walk(Energy energia, Position posicion);
        void Run(Energy energia, Position posicion);
    }
}