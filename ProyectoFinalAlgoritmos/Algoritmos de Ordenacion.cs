using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Algoritmos_de_Ordenacion : Form
    {
        public Algoritmos_de_Ordenacion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            this.Hide();
            NumerosIngresadosManualmente acceso = new NumerosIngresadosManualmente();
            acceso.Show();
        }

        private void btnburbujaBandera_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionBurbujaBandera acceso = new OrdenacionBurbujaBandera();
            acceso.Show();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionSeleccion acceso = new OrdenacionSeleccion();
            acceso.Show();
        }

        private void btnInsercion_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionInsercion acceso = new OrdenacionInsercion();
            acceso.Show();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionMergeSort acceso = new OrdenacionMergeSort();
            acceso.Show();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionRadixSort acceso = new OrdenacionRadixSort();
            acceso.Show();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionQuickSort acceso = new OrdenacionQuickSort();
            acceso.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdenacionShell acceso = new OrdenacionShell();
            acceso.Show();
        }
    }
}
