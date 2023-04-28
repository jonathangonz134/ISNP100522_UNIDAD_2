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
            Ejercicio_2 METROS_A_YARDAS = new Ejercicio_2();
            METROS_A_YARDAS.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ejercicio_3 CALCULADORA = new Ejercicio_3();
            CALCULADORA.Show();

            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ejercicio_4 POS = new Ejercicio_4();
            POS.Show();

            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Ejercicio_5 CALIFICACIONES = new Ejercicio_5();
            CALIFICACIONES.Show();

            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ejercicio_6 EJERCICIO_6 = new Ejercicio_6();
            EJERCICIO_6.Show();

            this.Hide();
        }

        private void btnSiguienteMenu_Click(object sender, EventArgs e)
        {
            MENU_2 menu_2 = new MENU_2();
            menu_2.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
