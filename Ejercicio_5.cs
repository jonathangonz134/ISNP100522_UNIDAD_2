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
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, notaFinal;

            if (!double.TryParse(txtPrimerParcial.Text, out nota1))
            {
                MessageBox.Show("Ingresa una nota valida para el Primer Parcial");
                return;
            }
            if (!double.TryParse(txtSegundoParcial.Text, out nota2))
            {
                MessageBox.Show("Ingrese una nota valida para el Segundo Parcial");
                return;
            }
            if (!double.TryParse(txtTercerParcial.Text, out nota3))
            {
                MessageBox.Show("Ingrese una nota valida para el Tercel Parcial");
                return;
            }
            if (!double.TryParse(txtLaboratorio.Text, out nota4)) 
            {
                MessageBox.Show("Ingrese una nota valida para el Laboratorio");
                return;
            }

            notaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

            MessageBox.Show("La nota final es: " + notaFinal.ToString());


            txtPrimerParcial.Text = string.Empty;
            txtSegundoParcial.Text= string.Empty;
            txtTercerParcial.Text = string.Empty;
            txtLaboratorio.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();

            this.Hide();
        }
    }
}
