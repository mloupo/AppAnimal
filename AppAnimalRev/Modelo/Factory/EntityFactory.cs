
using static AppAnimalRev.Enums;

namespace AppAnimalRev
{
    public class EntityFactory : IFactoryMethod
    {
        public EntityFactory() { }

        public IEntity GetCreation(TipoCreacion name)
        {
            IEntity entity = null;
            switch (name)
            {
                case TipoCreacion.Animal:
                    entity = new Animal();
                    break;
                case TipoCreacion.Planta:
                    entity = new Planta();
                    break;
                case TipoCreacion.Comida:                    
                    entity = new Food();
                    break;
            }
            return entity;
        }
    }
}
