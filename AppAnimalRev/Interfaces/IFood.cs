using AppAnimalRev.Modelo.Kingdom;

namespace AppAnimalRev
{
    public interface IFood
    {
        int SumarCalorias(IFood comida);
    }
}