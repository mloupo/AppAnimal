using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using static AppAnimalRev.StaticFunctions;
namespace AppAnimalRev
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  IStringInteractor interactor = new ConsoleInteractor();

            IFactoryMethod factory = new EntityFactory();

            IEntity OComida = factory.GetCreation(Enums.TipoCreacion.Comida);
            interactor.write(OComida.GetName());
            interactor.read();

            IEntity OAnimal = factory.GetCreation(Enums.TipoCreacion.Animal);
            interactor.write(OAnimal.GetName());
            interactor.read();

            IEntity OVegetal = factory.GetCreation(Enums.TipoCreacion.Planta);
            interactor.write(OVegetal.GetName());
            interactor.read();


            double prome = Promedio( 27, 9, 18);
            Console.WriteLine("El promedio es: " + prome);*/

            Console.WriteLine(char.IsDigit('.')); 
            
            for (int i=0, j=5; i < 6; i++, j--) 
            {
                Console.WriteLine("i={0}, j={1}", i, j); 
            }
            Console.ReadLine();
        }
    }
}

