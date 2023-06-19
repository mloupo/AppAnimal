using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public class Omnivorous : IDiet
    {
       
        public bool CanEat(Food food)
        {
            return food.GetType() == typeof(VegetalFood) || food.GetType() == typeof(AnimalFood); 
        }

        public override string ToString()
        {
            return "Soy Omnívoro";
        }    
    }
}

