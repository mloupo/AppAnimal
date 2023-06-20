
using AppAnimalRev.Interfaces.Enviroment;

namespace AppAnimal.Modelo.Concretas
{
    public class Acuatic : IAcuatic
    {
        public void Move()
        {
            throw new System.NotImplementedException();
        }
        // usar strategy con move() para que quede dentro de otro metodo mas especifico

        public void Swim()
        {
            throw new System.NotImplementedException();
        }
    }
}

