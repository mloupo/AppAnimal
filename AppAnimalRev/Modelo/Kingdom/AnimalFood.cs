using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Modelo.Vitalidad;
using System;

namespace AppAnimalRev.Modelo.Kingdom
{
    internal class AnimalFood : Food, IEntity, IFood
    {

        public AnimalFood(string name, int peso, int age) :base ()
        {
            Name = name;
            Peso = peso;
            Age = age;
        }
        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public void SumarCalorias(Energy energia)
        {
            energia.setEstado(this.energy.getEstado());
        }

        public string WhoIAm()
        { return GetType().Name; }

        public override string ToString()
        {
            return "Soy " + Name  + ", de Origen Animal";
        }

        protected override void ShowId()
        {
            Console.WriteLine(lastId);
        }
    }
}
