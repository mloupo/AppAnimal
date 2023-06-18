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
                    entity = new Animalia("Lila");
                    break;
                case TipoCreacion.Plantae:
                    entity = new Plantae("Maria Juana");
                    break;
                case TipoCreacion.Comida:                    
                    entity = new Food("Tomate");
                    break;
            }
            return entity;
        }
    }
}
