
namespace ProyectoFinalAlgoritmos
{
    partial class Algoritmos_de_Ordenacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnburbujaBandera = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(271, 77);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(133, 53);
            this.btnBurbuja.TabIndex = 0;
            this.btnBurbuja.Text = "Ordenacion Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnburbujaBandera
            // 
            this.btnburbujaBandera.Location = new System.Drawing.Point(601, 77);
            this.btnburbujaBandera.Name = "btnburbujaBandera";
            this.btnburbujaBandera.Size = new System.Drawing.Size(133, 53);
            this.btnburbujaBandera.TabIndex = 1;
            this.btnburbujaBandera.Text = "Ordenacion Burbuja Bandera";
            this.btnburbujaBandera.UseVisualStyleBackColor = true;
            this.btnburbujaBandera.Click += new System.EventHandler(this.btnburbujaBandera_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(271, 185);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(133, 53);
            this.btnSeleccion.TabIndex = 2;
            this.btnSeleccion.Text = "Ordenacion Seleccion";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnInsercion
            // 
            this.btnInsercion.Location = new System.Drawing.Point(601, 185);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(133, 53);
            this.btnInsercion.TabIndex = 3;
            this.btnInsercion.Text = "Ordenacion Insercion";
            this.btnInsercion.UseVisualStyleBackColor = true;
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(271, 303);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(133, 53);
            this.btnShell.TabIndex = 4;
            this.btnShell.Text = "Ordenacion Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(601, 303);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(133, 53);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Ordenacion Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(271, 429);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(133, 53);
            this.btnQuick.TabIndex = 6;
            this.btnQuick.Text = "Ordenacion Quick Sort";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(601, 429);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(133, 53);
            this.btnRadix.TabIndex = 7;
            this.btnRadix.Text = "Ordenacion Radix Sort";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(49, 40);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 31);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Algoritmos_de_Ordenacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 559);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnInsercion);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnburbujaBandera);
            this.Controls.Add(this.btnBurbuja);
            this.Name = "Algoritmos_de_Ordenacion";
            this.Text = "Algoritmos_de_Ordenacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnburbujaBandera;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnInsercion;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Button btnRegresar;
    }
}