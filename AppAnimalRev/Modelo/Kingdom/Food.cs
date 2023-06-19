using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;
using System.Xml.Linq;

namespace AppAnimalRev.Modelo.Kingdom

{
    public class Food : Thing, IEntity , IFood 
    {
        protected string kingdom = "Comida";
        protected Energy Energy;
        protected string Diet = String.Empty;

        public Food() { }

        public Food(string name, string diet, int peso, int age) 
        {
            Name = name;
            Diet = diet;
            Peso = peso;
            Age = age;
        }

        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public int SumarCalorias()
        { throw new NotImplementedException(); }

        public string WhoIAm()
        {  return kingdom; }
    }
}
