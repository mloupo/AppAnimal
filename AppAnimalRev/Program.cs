using AppAnimalRev.Modelo.Factory;
using System;
namespace AppAnimalRev
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            
            IFactoryMethod factory = new EntityFactory();

            IEntity OComida = factory.GetCreation(Enums.TipoCreacion.Comida);
            Console.WriteLine(OComida.WhoIAm());
            Console.ReadLine();

            IEntity OAnimal = factory.GetCreation(Enums.TipoCreacion.Animalia);
            Console.WriteLine(OAnimal.WhoIAm());
            Console.ReadLine();
            
            IEntity OVegetal = factory.GetCreation(Enums.TipoCreacion.Plantae);
            Console.WriteLine(OVegetal.WhoIAm());
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

