using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public class Hervivorous : IDiet
    {
        public bool CanEat(Food food)
        {
            return food.WhoIAm() is "Plantae";
            
        }
        public override string ToString()
        {
            return "Soy Hervivoro";
        }


    }
}