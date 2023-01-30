using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class CalculoSeno : Form
    {
        int n, c;
        double signo = 1;
        double x, f, sinx;
        public CalculoSeno()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otros_Algoritmos acceso = new Otros_Algoritmos();
            acceso.Show();
        }

        private void btnMaxExponente_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtMaximoExponente.Text);
            MessageBox.Show("Se ha ingresado el maximo exponente");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            x = double.Parse(txtX.Text);
            sinx = x;
            MessageBox.Show("Se ha ingresado el valor");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < n; i = i + 2)
            {
                c = 1;
                int f = 1;
                while (c <= i)
                {
                    f = f * c;
                    c++;
                }
                if (signo % 2 == 1)
                {
                    sinx = sinx - ((Math.Pow(x, i)) / f);
                }
                else
                {
                    sinx = sinx + ((Math.Pow(x, i)) / f);
                }
                signo = signo + 1;
            }
            MessageBox.Show("El seno de " + x + "es: " + sinx);
        }
    }
}
