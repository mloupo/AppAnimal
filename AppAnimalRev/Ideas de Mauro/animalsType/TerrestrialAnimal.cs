using SmallWorld.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.model.animalsType
{
    internal class TerrestrialAnimal : IAnimal, Ipositionable
    {
        private string Specie { get; set; }
        private double Weight { get; set; }
        private int Age { get; set; }
        private IDiet Diet { get; set; }
        private int PosX { get; set; }
        private int PosY { get; set; }

        public TerrestrialAnimal(string specie, double weight, int age, IDiet diet)
        {
            Specie = specie;
            Weight = weight;
            Age = age;
            Diet = diet;
        }
        public string GetSpecie()
        {
            return Specie;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public IDiet GetDiet()
        {
            return Diet;
        }

        public int GetAge()
        {
            return Age;
        }
     
        public int GetPosX()
        {
            return PosX;
        }
        public int GetPosY()
        {
            return PosY;
        }
        public bool Feed(IFood food)
        {
            return Diet.CanEat(food);
        }
        public bool Move()
        {
            throw new NotImplementedException();
        }

        public bool Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
