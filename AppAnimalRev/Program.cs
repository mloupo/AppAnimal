using AppAnimalRev.Interfaces;
using AppAnimalRev.Modelo.Factory;
using AppAnimalRev.Modelo.Kingdom;
using AppAnimalRev.Services;
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
            Console.ReadLine();
            
            IEntity OVegetal = factory.GetCreation(Enums.TipoCreacion.Plantae);
            Console.WriteLine(OVegetal.WhoIAm());
            Console.WriteLine(OVegetal.ToString());
            Console.ReadLine();

            Animalia animal = (Animalia)OAnimal;
            Plantae planta = (Plantae)OVegetal;
            AnimalFood comidaAnimal = (AnimalFood)OComidaAnimal;
            VegetalFood comidaVegetal = (VegetalFood)OComidaVegetal;

            IFood comidita = (IFood)OComidaVegetal;
            IFood comidita2 = (IFood)OComidaAnimal;
            animal.Eat(comidita);
            animal.Eat(comidita2);
            Console.ReadLine();           

            AlmacenGenerico<VegetalFood> listaComidaVegetal = new AlmacenGenerico<VegetalFood>(10);
            AlmacenGenerico<AnimalFood> listaComidaAnimal = new AlmacenGenerico<AnimalFood>(10);
            AlmacenGenerico<Animalia> listaAnimales = new AlmacenGenerico<Animalia>(10);
            AlmacenGenerico<Plantae> listaPlantas = new AlmacenGenerico<Plantae>(10);

            listaAnimales.Agregar(animal);
            listaComidaVegetal.Agregar(comidaVegetal);
            listaComidaAnimal.Agregar(comidaAnimal);
            listaPlantas.Agregar(planta);
        }
    }
}

