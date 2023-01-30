using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class OrdenacionQuickSort : Form
    {
        string[] numeros = new string[0];
        int[] arreglo = new int[0];
        int contador = 0;
        int cantidad = 0;
        public OrdenacionQuickSort()
        {
            InitializeComponent();
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

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            quicksort(arreglo, 0, arreglo.Length-1);
            for (int x = 0; x < arreglo.Length; x++)
            {
                lblResultado.Text = lblResultado.Text + " ," + arreglo[x];
            }
        }
        private void quicksort(int[] arreglo, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = arreglo[central];
            i = primero;
            j = ultimo;
            do
            {
                while (arreglo[i] < pivote) i++;
                while (arreglo[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(arreglo, primero, j);

            }
            if (i < ultimo)
            {
                quicksort(arreglo, i, ultimo);

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Ordenacion acceso = new Algoritmos_de_Ordenacion();
            acceso.Show();
        }
    }
}
