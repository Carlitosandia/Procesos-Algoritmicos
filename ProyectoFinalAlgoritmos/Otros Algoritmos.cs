using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Otros_Algoritmos : Form
    {
        public Otros_Algoritmos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculoSeno acceso = new CalculoSeno();
            acceso.Show();
        }
    }
}
