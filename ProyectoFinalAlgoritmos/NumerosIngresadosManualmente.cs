using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class NumerosIngresadosManualmente : Form
    {
        string[] numeros = new string[0];
        int[] arreglo = new int[0];
        int contador = 0;
        int cantidad = 0;
        public NumerosIngresadosManualmente()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<numeros.Length;i++)
            {
                if (numeros[i] == null)
                {
                    numeros[i] = txtNumero.Text;
                    arreglo[i] = int.Parse(numeros[i]);
                    contador++;
                    break;
                }
            }
            lblContador.Text = contador.ToString();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < (arreglo.Length - 1); j++)
            {
                for (int i = 0; i < arreglo.Length - 1 - j; i++)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        int Aux = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = Aux;
                    }
                }
            }
            for (int x = 0; x<arreglo.Length;x++)
            {
                lblResultado.Text = lblResultado.Text+ " ,"+ arreglo[x];
            }
        }

        private void btnResizeArray_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad = int.Parse(txtArray.Text);
                Array.Resize(ref numeros, cantidad);
                Array.Resize(ref arreglo, cantidad);
                MessageBox.Show("Se cambio el tamaño del arreglo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha ingresado un numero \n"+ex);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Ordenacion back = new Algoritmos_de_Ordenacion();
            back.Show();
        }

        private void lblInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void txtArray_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void lblTxtContador_Click(object sender, EventArgs e)
        {

        }
    }
}
