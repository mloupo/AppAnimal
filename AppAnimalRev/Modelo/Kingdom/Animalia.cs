using AppAnimal.Modelo.Abstractas;
using AppAnimalRev.Interfaces;
using AppAnimalRev.Interfaces.Breathing;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;
using System.Web;

namespace AppAnimalRev.Modelo.Kingdom
{
    public class Animalia : Organic, IEntity, IAnimal, IBreathing, IEnviroment 
        // IEnviroment tambien podria ser un enum por ahora

    {
        protected string kingdom = "Animalia";
        protected Energy Energia;
        protected int Age;
        protected string Diet = String.Empty;

      
        public string WhoIAm() { return "Animalia"; }

        public void Breathe() { throw new NotImplementedException(); }

        public void sleep() { throw new NotImplementedException(); }

        public void move() { throw new NotImplementedException(); }

        public void Eat(Food Comida) { throw new NotImplementedException(); }

        public void Move(IEntity entidad) { throw new NotImplementedException(); }

        public void Sleep() { throw new NotImplementedException(); }

        public void BackToLife(Energy energia)
        {
            throw new NotImplementedException();
        }

        public Animalia(string name)
        {
            Name = name;            
        }
    }
}
