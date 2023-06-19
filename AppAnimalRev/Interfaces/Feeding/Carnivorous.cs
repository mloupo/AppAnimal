using AppAnimalRev;
using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimal.Interfaces.Feeding
{
    public class Carnivorous : IDiet
    {
       
        public bool CanEat(Food food)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Carnívoro";
        }

    
    }
}