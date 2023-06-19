using AppAnimal.Modelo.Posicion;

namespace AppAnimalRev
{
    public abstract class Thing
    {
        protected string Name = string.Empty;
        protected int Id; // Hacer autoincremental asi todo tiene un identificador unico
        protected Position Position;
        protected int Peso;
        protected int Age;
    }

}