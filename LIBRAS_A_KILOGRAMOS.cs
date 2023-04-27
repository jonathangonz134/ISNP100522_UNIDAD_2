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
    public partial class LIBRAS_A_KILOGRAMOS : Form
    {
        public LIBRAS_A_KILOGRAMOS()
        {
            InitializeComponent();
        }

        private void btnLibrasAKilo_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtLibras.Text, out double libras))
            {
                
                double kilogramos = libras * 0.45359237;
                txtKilogramos.Text = kilogramos.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en libras");
            }
        }

        private void btnKiloALibras_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKilogramos2.Text, out double kilogramos)) 
            {
                double libras = kilogramos * 2.20462262;
                txtLibras2.Text = libras.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido en Kilogramos");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();

            this.Hide();
        }
    }
}

