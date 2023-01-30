using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class OrdenacionMergeSort : Form
    {
        string[] numeros = new string[0];
        int[] arreglo = new int[0];
        int contador = 0;
        int cantidad = 0;
        public OrdenacionMergeSort()
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
            mergeSort(arreglo, 0, arreglo.Length-1);
            for (int x = 0; x < arreglo.Length; x++)
            {
                lblResultado.Text = lblResultado.Text + " ," + arreglo[x];
            }
        }
        private void mergeSort(int[] arr, int p, int r)
        {
            //arr es arreglo, p es inicio, r es el final del arreglo
            if (p < r)
            {
                int m = (p + r) / 2;
                mergeSort(arr, p, m);
                mergeSort(arr, m + 1, r);
                merge(arr, p, m, r);
            }
        }
        private void merge(int[] arr, int p, int m, int r)
        {
            int i, j, k;

            int n1 = m - p + 1;

            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;
            k = p;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
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
