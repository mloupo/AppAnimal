using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public class Hervivorous : IDiet
    {
        public bool CanEat(IFood food)
        {
            return food.GetType() == typeof(AnimalFood);
        }

        public override string ToString()
        {
            return "Soy Hervivoro";
        }


    }
}