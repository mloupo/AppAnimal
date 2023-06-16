using System;
using System.Windows.Forms;

namespace PruebaIdeas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            /*Product oProduct= new Product(100);
            Console.WriteLine("Precio de venta calculado: {0}", oProduct.PrecioVenta);            
            Console.WriteLine("Impuesto asociado calculado: {0}",oProduct.Impuesto);
            Console.WriteLine("Productos en stock: {0}",oProduct.Inventario);
            Console.WriteLine("La Garantia es de {0} años", oProduct.Garantia);
            oProduct.definirGarantia(12345, 3);
            Console.WriteLine("La Garantia es de {0} años", oProduct.Garantia);
            Console.ReadLine();*/

            //MessageBox.Show("Test");
        }
    }
}
