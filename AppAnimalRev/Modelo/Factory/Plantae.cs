using AppAnimalRev.Modelo.Abstractas.No;
using System;

namespace AppAnimalRev
{
    public class Plantae : Thing, IEntity
    {
        private string kingdom = "Plantae";
        private string name = String.Empty;
        protected Energy Energia;
        protected string Species = String.Empty;
        protected int Age;
        protected string Diet = String.Empty;
        public string GetName()
        {
            return Name;
        }

        public Plantae()
        {
            Name = name;
        }
    }
} 