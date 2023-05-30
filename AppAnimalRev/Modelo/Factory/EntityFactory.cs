
namespace AppAnimalRev
{
    public class EntityFactory : IFactoryMethod
    {
        public EntityFactory() { }

        public IEntity GetProduct(string name)
        {
            IEntity entity = null;
            switch (name)
            {
                case "Animal":
                    entity = new Animal();
                    break;
                case "Planta":
                    entity = new Planta();
                    break;
                case "Comida":                    
                    entity = new Food();
                    break;
            }
            return entity;
        }
    }
}
