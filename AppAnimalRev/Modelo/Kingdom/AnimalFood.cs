using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Modelo.Vitalidad;
using System;

namespace AppAnimalRev.Modelo.Kingdom
{
    internal class AnimalFood : Food, IEntity, IFood
    {

        public AnimalFood(string name, int peso, int age)
        {
            Name = name;
            Peso = peso;
            Age = age;
        }
        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public void SumarCalorias(Energy energia)
        {
            energia.Estado(this.energy.Estado());
        }

        public string WhoIAm()
        { return GetType().ToString(); }

        public override string ToString()
        {
            return "Soy " + Name  + " de Origen Animal";
        }
    }
}
