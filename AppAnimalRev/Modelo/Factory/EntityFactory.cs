using AppAnimal.Interfaces.Feeding;
using AppAnimalRev.Modelo.Kingdom;
using static AppAnimalRev.Enums;

namespace AppAnimalRev.Modelo.Factory
{
    public class EntityFactory : IFactoryMethod
    {
        public EntityFactory() { }

        public IEntity GetCreation(TipoCreacion kingdom)
        {
            IEntity entity = null;
            switch (kingdom)
            {
                case TipoCreacion.Animalia:
                    entity = new Animalia();
                    break;
                case TipoCreacion.Plantae:
                    entity = new Plantae();
                    break;
                case TipoCreacion.ComidaOrigenAnimal:                    
                    entity = new AnimalFood("Carne", 2 , 22 );
                    break;
                case TipoCreacion.ComidaOrigenVegetal:
                    entity = new VegetalFood("Tomates", 1, 1);
                    break;
            }
            return entity;
        }
    }
}
