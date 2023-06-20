using AppAnimalRev.Interfaces;
using AppAnimalRev.Modelo.Factory;
using AppAnimalRev.Modelo.Kingdom;
using System;
using System.Windows.Forms;

namespace AppAnimalRev
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCreate());
            */

            IFactoryMethod factory = new EntityFactory();

            IEntity OComidaVegetal = factory.GetCreation(Enums.TipoCreacion.ComidaOrigenVegetal);
            Console.WriteLine(OComidaVegetal.WhoIAm());
            Console.WriteLine(OComidaVegetal.ToString());

            Console.ReadLine();

            IEntity OComidaAnimal = factory.GetCreation(Enums.TipoCreacion.ComidaOrigenAnimal);
            Console.WriteLine(OComidaAnimal.WhoIAm());
            Console.WriteLine(OComidaAnimal.ToString());
            Console.ReadLine();

            IEntity OAnimal = factory.GetCreation(Enums.TipoCreacion.Animalia);
            Console.WriteLine(OAnimal.WhoIAm());
            Console.WriteLine(OAnimal.ToString());
            Animalia animal = (Animalia)OAnimal;
            IFood comidita = (IFood)OComidaVegetal;
            IFood comidita2 = (IFood)OComidaAnimal;
            animal.Eat(comidita);
            animal.Eat(comidita2);
            Console.ReadLine();

            IEntity OVegetal = factory.GetCreation(Enums.TipoCreacion.Plantae);
            Console.WriteLine(OVegetal.WhoIAm());
            Console.WriteLine(OVegetal.ToString());
            Console.ReadLine();

        }
    }
}

