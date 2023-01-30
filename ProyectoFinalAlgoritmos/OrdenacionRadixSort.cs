using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class OrdenacionRadixSort : Form
    {
        string[] numeros = new string[0];
        int[] arreglo = new int[0];
        int contador = 0;
        int cantidad = 0;
        public OrdenacionRadixSort()
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
            int[] t = new int[arreglo.Length];
            int r = 4;
            int b = 32;
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];
            int groups = (int)Math.Ceiling((double)b / (double)r);
            int mask = (1 << r) - 1;
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                for (int i = 0; i < arreglo.Length; i++)
                    count[(arreglo[i] >> shift) & mask]++;

                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                for (int i = 0; i < arreglo.Length; i++)
                    t[pref[(arreglo[i] >> shift) & mask]++] = arreglo[i];
                t.CopyTo(arreglo, 0);
            }
            for (int x = 0; x < arreglo.Length; x++)
            {
                lblResultado.Text = lblResultado.Text + " ," + arreglo[x];
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
