using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Busqueda acceso = new Algoritmos_de_Busqueda();
            acceso.Show();
        }

        private void btnOrdenacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Ordenacion acceso = new Algoritmos_de_Ordenacion();
            acceso.Show();
        }

        private void btnProcesamientoImg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmos_de_Procesamiento acceso = new Algoritmos_de_Procesamiento();
            acceso.Show();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otros_Algoritmos acceso = new Otros_Algoritmos();
            acceso.Show();
        }
    }
}
