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
    public partial class Ejercicio_10 : Form
    {
        public Ejercicio_10()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtContraseña.Text;
            string contraseña = txtUsuario.Text;

            if (usuario == "ugb" && contraseña == "ugb")
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }

            txtContraseña.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MENU_2 menu_2 = new MENU_2();
            menu_2.Show();

            this.Hide();
        }
    }
}
