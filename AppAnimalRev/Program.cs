namespace AppAnimalRev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStringInteractor interactor = new ConsoleInteractor();

            IFactoryMethod factory = new EntityFactory();

            IEntity OComida = factory.GetProduct("Comida");
            interactor.write(OComida.GetName());
            interactor.read();

            IEntity OAnimal = factory.GetProduct("Animal");
            interactor.write(OAnimal.GetName());
            interactor.read();

            IEntity OVegetal = factory.GetProduct("Planta");
            interactor.write(OVegetal.GetName());
            interactor.read();
        }
    }
}
