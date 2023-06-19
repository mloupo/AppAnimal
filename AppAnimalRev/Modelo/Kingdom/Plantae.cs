using AppAnimalRev.Modelo.Vitalidad;
using System;

namespace AppAnimalRev.Modelo.Kingdom
{
    public class Plantae : Thing, IEntity
    {
        protected string kingdom = "Plantae";
        protected Energy Energia;
        
        public string WhoIAm()
        {
            return "Plantae";
        }

        public void BringMeToLife(Energy energia)
        {
            throw new NotImplementedException();
        }

        public Plantae(string name)
        {
            Name= name;
        }
    }
} 