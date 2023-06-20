using System;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Modelo.Kingdom
{
    internal class VegetalFood : Food, IEntity, IFood
    {
        public VegetalFood(string name, int peso, int age)
        {
            Name = name;
            Peso = peso;
            Age = age;
        }

        public void BringMeToLife(Energy energia)
        { throw new NotImplementedException(); }

        public void SumarCalorias(Energy energia)
        { throw new NotImplementedException(); }

        public string WhoIAm()
        { return GetType().ToString(); }

        public override string ToString()
        {
            return "Soy " + Name + ", de Origen Vegetal";
        }

        protected override void ShowId()
        {
            Console.WriteLine(lastId);
        }
    }
}
