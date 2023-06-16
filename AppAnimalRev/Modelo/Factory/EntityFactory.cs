
using static AppAnimalRev.Enums;

namespace AppAnimalRev
{
    public class EntityFactory : IFactoryMethod
    {
        public EntityFactory() { }

        public IEntity GetCreation(TipoCreacion kingdom)
        {
            IEntity entity = null;
            switch (kingdom)
            {
                case TipoCreacion.Animal:
                    entity = new Animalia();
                    break;
                case TipoCreacion.Planta:
                    entity = new Plantae();
                    break;
                case TipoCreacion.Comida:                    
                    entity = new Food();
                    break;
            }
            return entity;
        }
    }
}
