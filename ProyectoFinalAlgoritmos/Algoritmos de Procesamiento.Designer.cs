
namespace ProyectoFinalAlgoritmos
{
    partial class Algoritmos_de_Procesamiento
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
            this.btnVisualizacion = new System.Windows.Forms.Button();
            this.btnGrises = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisualizacion
            // 
            this.btnVisualizacion.Location = new System.Drawing.Point(237, 139);
            this.btnVisualizacion.Name = "btnVisualizacion";
            this.btnVisualizacion.Size = new System.Drawing.Size(193, 69);
            this.btnVisualizacion.TabIndex = 0;
            this.btnVisualizacion.Text = "Visualizacion";
            this.btnVisualizacion.UseVisualStyleBackColor = true;
            this.btnVisualizacion.Click += new System.EventHandler(this.btnVisualizacion_Click);
            // 
            // btnGrises
            // 
            this.btnGrises.Location = new System.Drawing.Point(661, 139);
            this.btnGrises.Name = "btnGrises";
            this.btnGrises.Size = new System.Drawing.Size(207, 69);
            this.btnGrises.TabIndex = 1;
            this.btnGrises.Text = "Escala de Grises";
            this.btnGrises.UseVisualStyleBackColor = true;
            this.btnGrises.Click += new System.EventHandler(this.btnGrises_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(71, 52);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 31);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Algoritmos_de_Procesamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 531);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGrises);
            this.Controls.Add(this.btnVisualizacion);
            this.Name = "Algoritmos_de_Procesamiento";
            this.Text = "Algoritmos_de_Procesamiento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizacion;
        private System.Windows.Forms.Button btnGrises;
        private System.Windows.Forms.Button btnRegresar;
    }
}