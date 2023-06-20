using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Vitalidad;
using System;
using System.Xml.Linq;

namespace AppAnimalRev.Modelo.Kingdom

{
    public abstract class Food : Thing
    {
        protected Energy energy; 
        protected Food() : base()
        {
            energy = new Energy(); 
        }
    }
}
