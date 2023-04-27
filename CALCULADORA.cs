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
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }


        bool detectaopreacion = true;
        string operacion;
        double result;
        double numero1;
        double numero2;
        bool punto = true;
       



        private void btn1_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "1";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "2";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }



        private void btn3_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "3";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }



        private void btn4_Click(object sender, EventArgs e)
        {
            if (!detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "3";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }



        private void btn5_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "5";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "6";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }



        private void btn7_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "7";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }



        private void btn8_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "8";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }



        private void btn9_Click(object sender, EventArgs e)
        {
            if (detectaopreacion)
            {
                txtPantalla.Text = string.Empty;
                txtPantalla.Text = "9";
                detectaopreacion = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                return;

            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            detectaopreacion = true;
            numero1 = double.Parse(txtPantalla.Text);
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            detectaopreacion = true;
            numero1 = double.Parse(txtPantalla.Text);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            detectaopreacion = true;
            numero1 = double.Parse(txtPantalla.Text);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            detectaopreacion = true;
            numero1 = double.Parse(txtPantalla.Text);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtPantalla.Text);
            result = Math.Sqrt(numero1);
            txtPantalla.Text = result.ToString();
            detectaopreacion = true;
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtPantalla.Text);
            result = numero1 * numero1;
            txtPantalla.Text = result.ToString();
        }

        

     

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                txtPantalla.Text = txtPantalla.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
            detectaopreacion = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            numero1 = 0;
            numero2 = 0;
            detectaopreacion = true;
            punto = true;
        }

      

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            detectaopreacion = true;
            numero1 = 0;
            numero2 = 0;
            result = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            numero2 = double.Parse(txtPantalla.Text);
            detectaopreacion = true;
            switch (operacion)
            {
                case "+":
                    result = numero1 + numero2;
                    txtPantalla.Text = result.ToString();
                    break;
                case "-":
                    result = numero1 - numero2;
                    txtPantalla.Text = result.ToString();
                    break;
                case "*":
                    result = numero1 * numero2;
                    txtPantalla.Text = result.ToString();
                    break;
                case "/":
                    result = numero1 / numero2;
                    txtPantalla.Text = result.ToString();
                    break;

            }
        }
    }        
}
