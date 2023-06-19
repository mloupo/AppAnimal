using AppAnimalRev.Interfaces.Feeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev.Modelo.Kingdom
{
    internal class VegetalFood : Food, IEntity, IFood
    {
        public VegetalFood(string name, string diet, int peso, int age)
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
