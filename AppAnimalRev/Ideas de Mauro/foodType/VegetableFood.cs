using SmallWorld.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.model.foodType
{
    internal class VegetableFood : IFood
    {
        private int Calories;
        private string Name;

        public VegetableFood(int calories, string name)
        {
            Calories = calories;
            Name = name;
        }

        public int GetCalories()
        {
            return Calories;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
