

namespace AppAnimalRev.Interfaces
{
    public interface IAnimal
    {
        void Eat(Food Comida);
        void Move(IEntity entidad);  //utiliza las coordenadas de posicion y la energia del objeto
                                            //Coordinates =(x,y)
                                            //return [Newposition(x,y), (energy-30)] 
        void Sleep(); //recupera el 50 % de energia
        string WhoIAm(); //Soy tal, de tal especie y tantos años

    }
}
