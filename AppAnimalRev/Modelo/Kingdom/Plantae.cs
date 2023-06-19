using AppAnimal.Interfaces.Feeding;
using AppAnimal.Modelo.Abstractas;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppAnimalRev.Modelo.Kingdom
{
    public class Plantae : Organic, IEntity
    {
        protected Energy Energia;

        public Plantae() { }

        public Plantae(string name, int peso, int age, string specie, IEnviroment Enviroment)
        {
            Name = name;            
            Peso = peso;
            Age = age;
            species = specie;
            enviroment = Enviroment;
        }       

        public string WhoIAm()
        { return "Plantae"; }

        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }     
    }
} 