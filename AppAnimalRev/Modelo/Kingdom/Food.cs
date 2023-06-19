using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;
using System.Xml.Linq;

namespace AppAnimalRev.Modelo.Kingdom

{
    public abstract class Food : Thing, IEntity , IFood 
    {
        protected Energy energy;
        public Food() { }
        
        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public int SumarCalorias()
        { throw new NotImplementedException(); }

        public string WhoIAm()
        { return "";/* return diet (que puede ser animal o vegetal*/}
    }
}
