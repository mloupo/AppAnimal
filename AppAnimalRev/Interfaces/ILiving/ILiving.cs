using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimal.Interfaces.ILiving
{
    public interface ILiving
    {
        void BackToLife(); /// Modificar para que le pase el animal c/ param y recargue su energia al 100%
                           //tambien llamar al momento de crear el animal para establecer la vida en 100%
    }
}
