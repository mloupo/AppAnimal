using AppAnimal.Modelo.Abstractas.No;
using AppAnimalRev.Interfaces;
using AppAnimalRev.Interfaces.IEnviroment;
using AppAnimalRev.Modelo.Abstractas.No;
using System;
namespace AppAnimalRev
{
    public class Animalia : Organic, IEntity, IAnimal, IBreathing, IEnviroment // IEnviroment tambien podria ser un enum por ahora

    {
        protected string kingdom = "Animalia";
        protected Energy Energia;        
        protected int Age;
        protected string Diet = String.Empty;

        public object ConsoleWriteLine { get; private set; }

        public string WhoIAm() { return "Animalia"; }
     
        public void Breathe() { throw new NotImplementedException(); }

        public void sleep() { throw new NotImplementedException(); }

        public void move() { throw new NotImplementedException(); }

        public void Eat(Food Comida) { throw new NotImplementedException(); }

        public void Move(IEntity entidad) { throw new NotImplementedException(); }

        public void Sleep() { throw new NotImplementedException(); }

        public Animalia() { }
    }
}
