using System;
using System.Windows.Forms;

using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using static AppAnimalRev.StaticFunctions;
namespace AppAnimalRev
{
    
    internal static class Program
    {
        static void Main(string[] args)
        {
            

            IStringInteractor interactor = new ConsoleInteractor();
            IFactoryMethod factory = new EntityFactory();

            IEntity OComida = factory.GetCreation(Enums.TipoCreacion.Comida);
            interactor.write(OComida.ToString());
            interactor.read();

            IEntity OAnimal = factory.GetCreation(Enums.TipoCreacion.Animalia);
            interactor.write(OAnimal.WhoIAm());
            interactor.read();

            IEntity OVegetal = factory.GetCreation(Enums.TipoCreacion.Plantae);
            interactor.write(OVegetal.WhoIAm());
            interactor.read();
            Console.ReadLine();

            /*1  


                 double prome = Promedio(27, 9, 18);
                 Console.WriteLine("El promedio es: " + prome);
            */

            /*2
                Console.WriteLine(char.IsDigit('.')); 

                for (int i=0, j=5; i < 6; i++, j--) 
                {
                    Console.WriteLine("i={0}, j={1}", i, j); 
                }
                Console.ReadLine();
            */
        }
    }
}

