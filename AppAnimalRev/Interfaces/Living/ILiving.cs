using AppAnimalRev.Modelo.Vitalidad;

namespace AppAnimal.Interfaces.Living
{ 
    public interface ILiving
    {
        void BackToLife(Energy energia); 
        /// Modificar para que le pase el animal c/ param y recargue su energia al 100%
        //tambien llamar al momento de crear el animal para establecer la vida en 100%
        // este metodo no deberia estar en esta interfaz y esta interfaz deberia tener otros metodos
    }
}
