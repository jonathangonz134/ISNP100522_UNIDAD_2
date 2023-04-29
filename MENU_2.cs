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
    public partial class MENU_2 : Form
    {
        public MENU_2()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ejercicio_7 ejercicio_7 = new Ejercicio_7();
            ejercicio_7.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ejercicio_8 ejercicio_8 = new Ejercicio_8();
            ejercicio_8.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ejercicio_9 ejercicio_9 = new Ejercicio_9();
            ejercicio_9.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ejercicio_10 ejercicio_10 = new Ejercicio_10();
            ejercicio_10.Show();

            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MENU MENU = new MENU();
            MENU.Show();

            this.Hide();
        }
    }
}
