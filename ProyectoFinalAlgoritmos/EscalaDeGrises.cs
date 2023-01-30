using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class EscalaDeGrises : Form
    {
        int filas = 0;
        int columnas = 0;
        int contador = 0;
        int contadorV = 0;
        int contadorA = 0;
        string[,] rojostring = new string[0, 0];
        int[,] rojo = new int[0, 0];

        string[,] verdestring = new string[0, 0];
        int[,] verde = new int[0, 0];

        string[,] azulstring = new string[0, 0];
        int[,] azul = new int[0, 0];

        int[,] gris = new int[0, 0];

        string arreglo;
        string arregloBinario;
        public EscalaDeGrises()
        {
            InitializeComponent();
            
        }

        private void btnValoresRojos_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (rojostring[f, c] == null)
                    {
                        rojostring[f, c] = txtValorRojo.Text;
                        rojo[f, c] = int.Parse(rojostring[f, c]);
                        contador++;
                        break;
                    }

                }
                
            }

            lblContadorRojo.Text = contador.ToString();
        }

        public void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            filas = int.Parse(txtNumeroFilas.Text);
            columnas = int.Parse(txtNumeroColumnas.Text);
            lblFilasyColumnas.Text = (txtNumeroFilas.Text + " x " + txtNumeroColumnas.Text);
            rojostring = new string[filas, columnas];
            rojo = new int[filas, columnas];

            verdestring = new string[filas, columnas];
            verde = new int[filas, columnas];

            azulstring = new string[filas, columnas];
            azul = new int[filas, columnas];

            gris = new int[filas,columnas];
        }

        private void btnValorVerde_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (verdestring[f, c] == null)
                    {
                        verdestring[f, c] = txtValorVerde.Text;
                        verde[f, c] = int.Parse(verdestring[f, c]);
                        contadorV++;
                        break;
                    }

                }
            }
            lblContadorVerde.Text = contadorV.ToString();
        }

        private void btnValorAzul_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (azulstring[f, c] == null)
                    {
                        azulstring[f, c] = txtValorAzul.Text;
                        azul[f, c] = int.Parse(azulstring[f, c]);
                        contadorA++;
                        break;
                    }

                }
            }
            lblContadorAzul.Text = contadorA.ToString();
        }

        private void btnAlgoritmo_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c <3; c++)
                {
                    double valorr;
                    valorr = (rojo[f, c] * 0.2989) + (verde[f, c] * 0.5870) + (azul[f, c] * 0.1140);
                    gris[f, c] = Convert.ToInt32(valorr);
                }
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    arreglo = arreglo + (gris[f, c] + " ");
                }
                arreglo = arreglo + "\n";
            }
            MessageBox.Show(arreglo);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Procesamiento acceso = new Algoritmos_de_Procesamiento();
            acceso.Show();
        }
    }
}
