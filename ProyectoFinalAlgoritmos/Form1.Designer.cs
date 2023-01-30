
namespace ProyectoFinalAlgoritmos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdenacion = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnOptimizacion = new System.Windows.Forms.Button();
            this.btnProcesamientoImg = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdenacion
            // 
            this.btnOrdenacion.Location = new System.Drawing.Point(228, 110);
            this.btnOrdenacion.Name = "btnOrdenacion";
            this.btnOrdenacion.Size = new System.Drawing.Size(226, 49);
            this.btnOrdenacion.TabIndex = 0;
            this.btnOrdenacion.Text = "Algoritmo Ordenacion";
            this.btnOrdenacion.UseVisualStyleBackColor = true;
            this.btnOrdenacion.Click += new System.EventHandler(this.btnOrdenacion_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(228, 228);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(226, 49);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Algoritmo Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            
            // 
            // btnProcesamientoImg
            // 
            this.btnProcesamientoImg.Location = new System.Drawing.Point(614, 228);
            this.btnProcesamientoImg.Name = "btnProcesamientoImg";
            this.btnProcesamientoImg.Size = new System.Drawing.Size(231, 49);
            this.btnProcesamientoImg.TabIndex = 3;
            this.btnProcesamientoImg.Text = "Algoritmo Procesamiento de Imagenes";
            this.btnProcesamientoImg.UseVisualStyleBackColor = true;
            this.btnProcesamientoImg.Click += new System.EventHandler(this.btnProcesamientoImg_Click);
            // 
            // btnOtros
            // 
            this.btnOtros.Location = new System.Drawing.Point(425, 351);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(204, 49);
            this.btnOtros.TabIndex = 4;
            this.btnOtros.Text = "Otros";
            this.btnOtros.UseVisualStyleBackColor = true;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 524);
            this.Controls.Add(this.btnOtros);
            this.Controls.Add(this.btnProcesamientoImg);
            this.Controls.Add(this.btnOptimizacion);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnOrdenacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenacion;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnOptimizacion;
        private System.Windows.Forms.Button btnProcesamientoImg;
        private System.Windows.Forms.Button btnOtros;
    }
}

