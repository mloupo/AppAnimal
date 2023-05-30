using AppAnimalRev.Modelo.Abstractas.No;
using System;

namespace AppAnimalRev
{
    public class Planta : Entity, IEntity
    {
        private string name = "Plantae";
        protected Energy Energia;
        protected string Species = String.Empty;
        protected int Age;
        protected string Diet = String.Empty;
        public string GetName()
        {
            return Name;
        }

        public Planta()
        {
            Name = name;
        }
    }
} 