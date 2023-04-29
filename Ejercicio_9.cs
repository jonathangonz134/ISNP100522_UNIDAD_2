using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP100522_UNIDAD_2
{
    public partial class Ejercicio_9 : Form
    {
        public Ejercicio_9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (double.TryParse(txtPrimerNumero.Text, out num1))
            {

            }
            else
            {
                MessageBox.Show("Ingrese un numero en el Primer contenedor");
                return;
            }

            if (double.TryParse(txtSegundoNumero.Text, out num2))
            {

            }
            else
            {
                MessageBox.Show("Ingrese un numero en el segundo contenedor");
                return;
            }

            if (num1 > num2)
            {
                MessageBox.Show("El numero Mayor es: " + num1);
            }
            else
            {
                MessageBox.Show("El numero Mayor es:" + num2);
            }

            txtPrimerNumero.Text = string.Empty;
            txtSegundoNumero.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU_2 MENU_2  = new MENU_2();
            MENU_2.Show();

            this.Hide();
        }
    }
}
