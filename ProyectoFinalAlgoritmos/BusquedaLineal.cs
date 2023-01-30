using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class BusquedaLineal : Form
    {
        string[] numeros = new string[0];
        int[] arreglo = new int[0];
        int contador = 0;
        int cantidad = 0;
        int buscador = 0;
        public BusquedaLineal()
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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (buscador == arreglo[i])
                {
                    MessageBox.Show("El valor que estabas buscando es " + arreglo[i] + " y esta en la posición " + i);
                }
                else
                {
                    MessageBox.Show("El valor no existe en el arreglo");
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Busqueda acceso = new Algoritmos_de_Busqueda();
            acceso.Show();
        }
    }
}
