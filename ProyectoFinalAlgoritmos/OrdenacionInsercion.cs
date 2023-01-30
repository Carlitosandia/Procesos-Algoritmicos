using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class OrdenacionInsercion : Form
    {
        string[] numeros = new string[0];
        int[] arreglo = new int[0];
        int contador = 0;
        int cantidad = 0;
        public OrdenacionInsercion()
        {
            InitializeComponent();
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
                MessageBox.Show("No se ha ingresado un numero \n" + ex);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numeros.Length; i++)
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
            int aux;
            int j;
            for (int i = 0; i < arreglo.Length; i++)
            {
                aux = arreglo[i];
                j = i - 1;
                while (j >= 0 && arreglo[j] > aux)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                }
                arreglo[j + 1] = aux;
            }
            for (int x = 0; x < arreglo.Length; x++)
            {
                lblResultado.Text = lblResultado.Text + " ," + arreglo[x];
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Ordenacion back = new Algoritmos_de_Ordenacion();
            back.Show();
        }
    }
}
