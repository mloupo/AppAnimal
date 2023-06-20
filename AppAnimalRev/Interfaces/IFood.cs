using AppAnimalRev.Modelo.Kingdom;
using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimalRev
{
    public interface IFood
    {
        void SumarCalorias(Energy energia);
    }
}