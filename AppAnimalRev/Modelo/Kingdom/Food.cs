using AppAnimalRev.Modelo.Vitalidad;
using System;
namespace AppAnimalRev.Modelo.Kingdom

{
    public class Food : Thing, IEntity , IFood 
    {
        protected string kingdom = "Comida";        
        protected Energy Energy;
        
        protected string Diet = String.Empty;

        public Food(string name) 
        {
            Name = name;
        }

        public void BringMeToLife(Energy energia)
        {
            throw new NotImplementedException();
        }

        public int SumarCalorias()
        {
            throw new NotImplementedException();
        }

        public string WhoIAm()
        {            
            return Diet;
        }
    }
}
