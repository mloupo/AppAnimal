using AppAnimalRev.Interfaces.Feeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using AppAnimal.Interfaces.Feeding;

namespace AppAnimalRev.Modelo.Kingdom
{
    internal class AnimalFood : Food
    {

        public AnimalFood(string name, int peso, int age)
        {
            Name = name;
            Peso = peso;
            Age = age;
        }



    }
}
