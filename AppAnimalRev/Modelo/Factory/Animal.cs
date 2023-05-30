using AppAnimalRev.Modelo.Abstractas.No;
using System;
namespace AppAnimalRev
{
    public class Animal : Entity, IEntity
    {
        private string name = "Animalia";
        protected Energy Energia;
        protected string Species = String.Empty;
        protected int Age;
        protected string Diet = String.Empty;        

        public string GetName()
        {
            return Name;
        }

        public Animal()
        {
            Name = name;
        }
    }
}
