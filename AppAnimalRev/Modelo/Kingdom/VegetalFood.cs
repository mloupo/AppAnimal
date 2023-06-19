using AppAnimalRev.Interfaces.Feeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AppAnimalRev.Modelo.Kingdom
{
    internal class VegetalFood : Food
    {
        public VegetalFood(string name, string diet, int peso, int age)
        {
            Name = name;
            Peso = peso;
            Age = age;
        }
    }
}
