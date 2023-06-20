using AppAnimal.Modelo.Posicion;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace AppAnimalRev
{
    public abstract class Thing
    {
        protected string Name = string.Empty;
        protected static int lastId = 0;
        protected Position Position;
        protected int Peso;
        protected int Age;
        
        protected int Id { get; set; }

        protected Thing() 
        {
            lastId++;
            Id = lastId;  
            Position = new Position();
        }

        protected abstract void ShowId();
     
    }

}