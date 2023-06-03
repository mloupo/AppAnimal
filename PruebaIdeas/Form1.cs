using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIdeas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetecta_Click(object sender, EventArgs e)
        {
            int ri = 0;
            double rd = 0.0;
            double CoeficienteSeguridad= 2.5;

            /*if (txtDato.Text == string.Empty)
                MessageBox.Show("No hay dato");
            else if (int.TryParse(txtDato.Text, out ri))
                MessageBox.Show("Es un numero entero: "+ ri);
            else if (double.TryParse(txtDato.Text, out rd))
                MessageBox.Show("Es un numero flotante: "+ rd);
            else
                MessageBox.Show("Es una cadena");*/

            if (txtDato.Text==string.Empty ||!double.TryParse(txtDato.Text, out rd)) {
                MessageBox.Show("Por favor, Introduzca un numero");
            }
            else {
                double resultado;
                resultado = Convert.ToDouble(txtDato.Text) * CoeficienteSeguridad;
                MessageBox.Show(resultado.ToString());
            }

        }
    }
}
