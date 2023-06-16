using AppAnimal.Modelo.Abstractas.No;
using AppAnimalRev.Modelo.Abstractas.No;
using System;
namespace AppAnimalRev
{
    public class Animalia : Organic, IEntity
    {
        protected string kingdom = "Animalia";
        protected Energy Energia;
        protected string Species = String.Empty;
        protected int Age;
        protected string Diet = String.Empty;        

        public string GetName()
        {
            return Name;
        }

        public Animalia()
        {
           
        }
    }
}
