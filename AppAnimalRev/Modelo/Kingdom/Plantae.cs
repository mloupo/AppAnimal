using AppAnimalRev.Modelo.Abstractas.No;
using System;

namespace AppAnimalRev
{
    public class Plantae : Thing, IEntity
    {
        private string _kingdom = "Plantae";
        private string _name = String.Empty;
        protected Energy Energia;
        protected int Age;
        public string WhoIAm()
        {
            return "Plantae";
        }

        public Plantae()
        {
            
        }
    }
} 