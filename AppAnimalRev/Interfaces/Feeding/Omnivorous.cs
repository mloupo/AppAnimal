using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public class Omnivorous : IDiet
    {
       
        public bool CanEat(Food food)
        {
            return food.WhoIAm() is "Animalia" || food.WhoIAm() is "Plantae";
        }
        public override string ToString()
        {
            return "Soy Omnívoro";
        }
    
    }
}

