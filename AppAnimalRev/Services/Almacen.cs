using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnimalRev.Services
{
    public class Almacen<T> where T: IEntity
    {
        private T[] datosElemento;
        private int i = 0;

        public Almacen(int z) 
        {
            datosElemento = new T[z];
        }   

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public T GetElemento(int i)
        {
            return datosElemento[i];
        }
    }
}
