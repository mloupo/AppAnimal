using AppAnimal.Modelo.Concretas.No;

namespace AppAnimalRev
{
    public abstract class Entity
    {
        protected string Name = string.Empty;
        protected int Id;
        protected Position Position;
        protected int Peso;
    }
}