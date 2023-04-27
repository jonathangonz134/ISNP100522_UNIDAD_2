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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            LIBRAS_A_KILOGRAMOS lIBRAS_A_KILOGRAMOS = new LIBRAS_A_KILOGRAMOS();
            lIBRAS_A_KILOGRAMOS.Show();
            
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            METROS_A_YARDAS METROS_A_YARDAS = new METROS_A_YARDAS();
            METROS_A_YARDAS.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CALCULADORA CALCULADORA = new CALCULADORA();
            CALCULADORA.Show();

            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            POS POS = new POS();
            POS.Show();

            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CALIFICACIONES CALIFICACIONES = new CALIFICACIONES();
            CALIFICACIONES.Show();

            this.Hide();
        }
    }
}
