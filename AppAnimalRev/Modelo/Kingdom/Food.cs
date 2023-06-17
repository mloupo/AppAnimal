using System;
namespace AppAnimalRev
{
    public class Food : Thing, IEntity
    {
        protected string kingdom = "Comida";
        protected string name = String.Empty;
        protected string Species = String.Empty;
        protected int Calories;
        protected int Age;
        protected int Diet;

        public Food()
        {

        }

        public string WhoIAm()
        {
            name = "Comida";
            return name;
        }
    }
}
