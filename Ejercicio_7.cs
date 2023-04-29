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
    public partial class Ejercicio_7 : Form
    {
        public Ejercicio_7()
        {
            InitializeComponent();
        }

        private void btnSiguienteMenu_Click(object sender, EventArgs e)
        {
            int contador = 1;
            int suma = 0;
            while (contador <= 100)
            {
                suma += contador;
                contador += 1;
            }

            MessageBox.Show("El resultado de " + suma);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU_2 menu_2 = new MENU_2();
            menu_2.Show();
            this.Hide();
        }
    }
}
