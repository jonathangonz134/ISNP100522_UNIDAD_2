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
    public partial class Ejercicio_6 : Form
    {
        public Ejercicio_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el número ingresado en el TextBox
            int numero = int.Parse(txtNumero.Text);

            // Verificar si el número está en el rango del 1 al 20
            if (numero < 1 || numero > 20)
            {
                MessageBox.Show("El número debe estar entre 1 y 20");
                return;
            }

            // Array de equivalencias de números romanos del 1 al 20
            string[] equivalenciasRomanas = { "I", "II", "III", "IV", "V", 
                                              "VI", "VII", "VIII", "IX", "X", 
                                              "XI", "XII", "XIII", "XIV", "XV", 
                                              "XVI", "XVII", "XVIII", "XIX", "XX" };

            // Obtener la equivalencia romana del número
            string equivalenciaRomana = equivalenciasRomanas[numero - 1];


            MessageBox.Show("Asi se representa tu numero en Romano: " + equivalenciaRomana);

            txtNumero.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();

            this.Hide();
        }
    }
}
