using System;
namespace AppAnimalRev
{
    public class Food : Entity, IEntity
    {
        private string name = "Comida";
        protected string Species = String.Empty;
        protected int Calories;
        protected int Age;
        protected int Diet;

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
