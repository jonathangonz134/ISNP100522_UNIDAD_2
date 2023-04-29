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
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad, precioUnitario, totalSinDescuento, totalConDescuento;

            cantidad = double.Parse(txtCantidad.Text);
            precioUnitario = double.Parse(txtPrecioUnitario.Text);

            totalSinDescuento = precioUnitario * cantidad;
            
            if (totalSinDescuento <= 2000)
            {
                totalConDescuento = totalSinDescuento * 0.15;
                MessageBox.Show("Gracias a su compra se le esta haciendo un descuento del 15%, El total a pagar es: " + totalConDescuento.ToString("C"));
            }
            else
            {
                totalConDescuento = totalSinDescuento * 0.35;
                MessageBox.Show("Gracias a su compra se le esta haciendo un descuento del 35%,El total a pagar es: " + totalConDescuento.ToString("C"));
            }

            txtCantidad.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();

            this.Hide();
        }
    }
}
