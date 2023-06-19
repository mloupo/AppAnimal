using AppAnimal.Interfaces.Living;

namespace AppAnimalRev
{
    public interface IEntity : ILiving
    {
        string WhoIAm();
    }
}
