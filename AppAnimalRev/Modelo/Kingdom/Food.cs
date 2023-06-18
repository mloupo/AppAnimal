using AppAnimalRev.Modelo.Vitalidad;
using System;
namespace AppAnimalRev.Modelo.Kingdom

{
    public class Food : Thing, IEntity
    {
        protected string kingdom = "Comida";        
        protected int Calories;
        protected int Age;
        protected string Diet = String.Empty;

        public Food(string name) 
        {
            Name = name;
        }

        public void BackToLife(Energy energia)
        {
            throw new NotImplementedException();
        }

        public string WhoIAm()
        {            
            return "Comida";
        }
    }
}
