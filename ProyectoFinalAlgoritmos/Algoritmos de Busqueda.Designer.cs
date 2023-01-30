
namespace ProyectoFinalAlgoritmos
{
    partial class Algoritmos_de_Busqueda
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
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(424, 99);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(216, 52);
            this.btnLineal.TabIndex = 0;
            this.btnLineal.Text = "Busqueda Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(424, 256);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(216, 51);
            this.btnBinaria.TabIndex = 1;
            this.btnBinaria.Text = "Busqueda Binaria";
            this.btnBinaria.UseVisualStyleBackColor = true;
            this.btnBinaria.Click += new System.EventHandler(this.btnBinaria_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(43, 25);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(93, 37);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Algoritmos_de_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 521);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBinaria);
            this.Controls.Add(this.btnLineal);
            this.Name = "Algoritmos_de_Busqueda";
            this.Text = "Algoritmos_de_Busqueda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Button btnRegresar;
    }
}