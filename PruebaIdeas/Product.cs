using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIdeas
{
    public class Product
    {
        private double precioCompra;
        private double descuento;
        private int garantia;

        public Product(double pPrecioCompra)
        {
            precioCompra = pPrecioCompra;
        }
      
        ~Product()
        {
        }
       
        //propiedad calculada
        public double PrecioVenta
        {
            get { return precioCompra * 1.40; }
        }

        //Propiedades de expresion representada
        public double Impuesto => PrecioVenta * 0.21;

        public double Descuento
        {
            get => precioCompra * (1 - descuento);
            set => descuento = value / 100;
        }

        //Inicializacion 
        public int Inventario { get; set; } = 30;

        //Accesibilidad
        public int Garantia
        {
            get { return garantia; }
            private set { garantia = value; }
        }

        public void definirGarantia(int pPassword, int pGarantia)
        {
           if (pPassword == 12345)
            {
                Garantia = pGarantia;
            }else 
                Console.WriteLine("Contraseña incorrecta");
        }
    }
}