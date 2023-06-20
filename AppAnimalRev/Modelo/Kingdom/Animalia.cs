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
        
        public Animalia(string name, IDiet diet, string specie, IEnviroment Enviroment, int peso, int age)
        {
            Name = name;
            Diet = diet;
            species = specie;
            enviroment = Enviroment;
            Peso = peso;
            Age = age;
            Energia = new Energy();
        }

        public string WhoIAm()
        { return GetType().ToString(); }

        public void Breathe()
        { throw new NotImplementedException(); }

        public void Sleep(Energy energia)
        { throw new NotImplementedException(); }

        public void Move()
        { throw new NotImplementedException(); }

        public void Eat(IFood comida)
        { 
          bool puedo = diet.CanEat(comida); 
           if (puedo)
            {
                comida.SumarCalorias(this.Energia);
                Console.WriteLine("Estaba Sabrosisimo, ahora estroy recargado de energias!!");
                Console.WriteLine("Mi energia ahora es de " + this.Energia.getEstado());
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
            return "Soy " + Name + ", y ademas " + Diet.ToString();
        }

        protected override void ShowId()
        {
            Console.WriteLine(lastId); ;
        }
    }
}
