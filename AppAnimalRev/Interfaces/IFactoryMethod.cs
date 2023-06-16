using static AppAnimalRev.Enums;

namespace AppAnimalRev
{
    public interface IFactoryMethod    {
        IEntity GetCreation(TipoCreacion kingdom);        
    }
}
