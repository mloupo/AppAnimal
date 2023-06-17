
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
                case TipoCreacion.Animalia:
                    entity = new Animalia();
                    break;
                case TipoCreacion.Plantae:
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
