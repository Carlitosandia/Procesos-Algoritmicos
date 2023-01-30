
namespace ProyectoFinalAlgoritmos
{
    partial class CalculoSeno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaximoExponente = new System.Windows.Forms.TextBox();
            this.btnMaxExponente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el maximo exponente";
            // 
            // txtMaximoExponente
            // 
            this.txtMaximoExponente.Location = new System.Drawing.Point(176, 165);
            this.txtMaximoExponente.Name = "txtMaximoExponente";
            this.txtMaximoExponente.Size = new System.Drawing.Size(150, 27);
            this.txtMaximoExponente.TabIndex = 1;
            // 
            // btnMaxExponente
            // 
            this.btnMaxExponente.Location = new System.Drawing.Point(176, 221);
            this.btnMaxExponente.Name = "btnMaxExponente";
            this.btnMaxExponente.Size = new System.Drawing.Size(132, 41);
            this.btnMaxExponente.TabIndex = 2;
            this.btnMaxExponente.Text = "Ingresar";
            this.btnMaxExponente.UseVisualStyleBackColor = true;
            this.btnMaxExponente.Click += new System.EventHandler(this.btnMaxExponente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa el valor de X";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(176, 415);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(132, 43);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "Ingresar";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(176, 353);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(150, 27);
            this.txtX.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(858, 415);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(126, 43);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(32, 35);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(93, 37);
            this.btnRegresar.TabIndex = 53;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // CalculoSeno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 527);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMaxExponente);
            this.Controls.Add(this.txtMaximoExponente);
            this.Controls.Add(this.label1);
            this.Name = "CalculoSeno";
            this.Text = "CalculoSeno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaximoExponente;
        private System.Windows.Forms.Button btnMaxExponente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegresar;
    }
}