using AppAnimalRev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev.Controladores
{
        internal class AnimalController : IController
        {
            private IController AnimalsController = new AnimalController();
            private List<IAnimal> Animals = new List<IAnimal>();

            private AnimalController() { }

            public void AddAnimal(IAnimal animal)
            { Animals.Add(animal); }

            public IController GetController()
            { return AnimalsController; }

            public List<IAnimal> getAnimals()
            { return Animals; }

            public void RemoveAllAnimals()
            { Animals.Clear(); }

            public void RemoveAnimal(IAnimal animal)
            { Animals.Remove(animal); }
        }
    
}
