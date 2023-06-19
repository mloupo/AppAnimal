using SmallWorld.src.interfaces;
using SmallWorld.src.model.foodType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.model.dietType
{
    internal class Hervivorous : IDiet
    {
        public bool CanEat(IFood food)
        {
            return food is VegetableFood;
        }
        public override string ToString()
        {
            return "Hervívoro";
        }
    }
}
