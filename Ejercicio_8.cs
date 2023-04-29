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
    public partial class Ejercicio_8 : Form
    {
        public Ejercicio_8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(numero.ToString() + "x" + i.ToString() + "=" + (numero * i).ToString());
            }

            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU_2 MENU_2 = new MENU_2();
            MENU_2.Show();

            this.Hide();
        }
    }
}
