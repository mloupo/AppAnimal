using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.interfaces
{
    internal interface IAnimal
    {
        string GetSpecie();
        double GetWeight();
        int GetAge();
        IDiet GetDiet();
        bool Move();
        bool Feed(IFood food);
        bool Sleep();

    }
}
