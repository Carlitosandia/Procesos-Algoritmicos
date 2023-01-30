using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Algoritmos_de_Busqueda : Form
    {
        public Algoritmos_de_Busqueda()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaBinaria acceso = new BusquedaBinaria();
            acceso.Show();
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaLineal acceso = new BusquedaLineal();
            acceso.Show();
        }
    }
}
