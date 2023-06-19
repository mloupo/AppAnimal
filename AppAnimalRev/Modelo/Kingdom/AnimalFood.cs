using AppAnimalRev.Interfaces.Feeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Modelo.Vitalidad;

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
        public string WhoIAm()
        { return GetType().ToString(); }


    }
}
