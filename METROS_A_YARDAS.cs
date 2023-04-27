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
    public partial class METROS_A_YARDAS : Form
    {
        public METROS_A_YARDAS()
        {
            InitializeComponent();
        }

        private void btnMetrosAYardas_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMetros.Text, out double metros))
            {
                double yardas = metros * 1.09361;
                txtYardas.Text = yardas.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores validos a Metros");
            }
        }

        private void btnYardasAMetros_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtYardas2.Text, out double yardas))
            {
                double metros = yardas / 1.09361;
                txtMetros2.Text = metros.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores validos a Yardas");
            }
        }

      

        private void btnCentimetrosAMilimetros_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCentimetros.Text, out double centimetros))
            {
                double milimetros = centimetros * 10;
                txtMilimetros.Text = milimetros.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores validos a Centimetros");
            }
        }


        private void btnMilimetrosACentimetros_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtmilimetros2.Text, out double milimetros))
            {
                double centimetros = milimetros /10;
                txtCentimetros2.Text = centimetros.ToString();
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
