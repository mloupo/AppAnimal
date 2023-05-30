using System;
namespace AppAnimalRev
{
    public class Animal : Entity, IEntity
    {
        string name = "Animal";
        public int Energy;
        public string Species = String.Empty;
        public int Age;
        public string Diet = String.Empty;        

        public string GetName()
        {
            return Name;
        }

        public Animal()
        {
            Name = name;
        }
    }
}
