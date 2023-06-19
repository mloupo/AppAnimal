using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public class Carnivorous : IDiet
    {
       
        public bool CanEat(Food food)
        {
            return food.WhoIAm() is "Animalia";
        }

        public override string ToString()
        {
            return "Soy Carnívoro";
        }

    
    }
}