using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public interface IDiet
    {
        bool CanEat(IFood food);
    }
}