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
    }
}
