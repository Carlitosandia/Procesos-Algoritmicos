using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Algoritmos_de_Procesamiento : Form
    {
        public Algoritmos_de_Procesamiento()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void btnGrises_Click(object sender, EventArgs e)
        {
            this.Hide();
            EscalaDeGrises acceso = new EscalaDeGrises();
            acceso.Show();
        }

        private void btnVisualizacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizacion acceso = new Visualizacion();
            acceso.Show();
        }
    }
}
