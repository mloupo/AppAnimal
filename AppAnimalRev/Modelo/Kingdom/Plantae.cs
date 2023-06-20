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
        private Energy energia;
        protected Energy Energia { get => energia; set => energia = value; }

        public Plantae(string name, int peso, int age, string specie, IEnviroment Enviroment)
        {
            Name = name;            
            Peso = peso;
            Age = age;
            species = specie;
            enviroment = Enviroment;
        }       

        public string WhoIAm()
        { return GetType().ToString(); }

        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public override string ToString()
        {
            return "Soy " + Name + ", de la especie " + species;
        }
    }
} 