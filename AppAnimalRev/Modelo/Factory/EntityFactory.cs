using AppAnimal.Interfaces.Feeding;
using AppAnimal.Modelo.Concretas;
using AppAnimalRev.Interfaces.Enviroment;
using AppAnimalRev.Modelo.Kingdom;
using static AppAnimalRev.Enums;

namespace AppAnimalRev.Modelo.Factory
{
    public class EntityFactory : IFactoryMethod
    {
        public EntityFactory() { }

        public IEntity GetCreation(TipoCreacion kingdom)
        {
            IDiet dieta = null;
            IEnviroment enviroment = null;
            IEntity entity = null;

            switch (kingdom)
            {
                case TipoCreacion.Animalia:
                    entity = new Animalia("Lila", dieta = new Carnivorous(), "Perro", enviroment = new Terrestrial(), 25, 10);
                    break;
                case TipoCreacion.Plantae:
                    entity = new Plantae("Maria Juana", 25, 10, "Cannabis", enviroment = new Terrestrial());
                    break;
                case TipoCreacion.ComidaOrigenAnimal:                    
                    entity = new AnimalFood("Carne", 2 , 22 );
                    break;
                case TipoCreacion.ComidaOrigenVegetal:
                    entity = new VegetalFood("Tomate", 1, 1);
                    break;
            }
            return entity;
        }
    }
}
