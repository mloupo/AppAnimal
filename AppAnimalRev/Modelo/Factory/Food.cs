using System;
namespace AppAnimalRev
{
    public class Food : Entity, IEntity
    {
        private string name = "Comida";
        public string Species = String.Empty;
        public int Calories;
        public int Age;
        public int Diet;

        public Food()
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
