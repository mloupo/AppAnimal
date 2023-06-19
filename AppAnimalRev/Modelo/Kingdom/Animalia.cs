using AppAnimal.Interfaces.Feeding;
using AppAnimal.Modelo.Abstractas;
using AppAnimal.Modelo.Posicion;
using AppAnimalRev.Interfaces;
using AppAnimalRev.Interfaces.Breathing;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;

namespace AppAnimalRev.Modelo.Kingdom
{
    public class Animalia : Organic, IEntity, IAnimal, IBreathing, IEnviroment
    {
        private Energy energia;
        private IDiet diet;

        protected Energy Energia { get => energia; set => energia = value; }
        protected IDiet Diet { get => diet; set => diet = value; }
        public Animalia() { }

        public Animalia(string name, IDiet diet, string specie, IEnviroment Enviroment, int peso, int age)
        {
            Name = name;
            Diet = diet;
            species = specie;
            enviroment = Enviroment;
            Peso = peso;
            Age = age;
        }

        public string WhoIAm()
        { return "Animalia"; }

        public void Breathe()
        { throw new NotImplementedException(); }

        public void Sleep(Energy energia)
        { throw new NotImplementedException(); }

        public void Move()
        { throw new NotImplementedException(); }

        public void Eat(Food comida)
        { 
          bool puedo = diet.CanEat(comida); 
           if (puedo)
            {
                
            }
           else
            {
                Console.WriteLine("No Puedo comer esto, " + diet.ToString());
            }

        
        
        }

        public void Move(Energy energia, Position posicion)
        { throw new NotImplementedException(); }

        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
