
namespace ProyectoFinalAlgoritmos
{
    partial class NumerosIngresadosManualmente
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblTxtContador = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnResizeArray = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(155, 347);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(158, 58);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar Numero";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(155, 290);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(158, 27);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(155, 241);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(214, 20);
            this.lblInstrucciones.TabIndex = 2;
            this.lblInstrucciones.Text = "Ingresa los numeros, uno a uno";
            this.lblInstrucciones.Click += new System.EventHandler(this.lblInstrucciones_Click);
            // 
            // lblTxtContador
            // 
            this.lblTxtContador.AutoSize = true;
            this.lblTxtContador.Location = new System.Drawing.Point(155, 443);
            this.lblTxtContador.Name = "lblTxtContador";
            this.lblTxtContador.Size = new System.Drawing.Size(156, 20);
            this.lblTxtContador.TabIndex = 4;
            this.lblTxtContador.Text = "Contador de Numeros";
            this.lblTxtContador.Click += new System.EventHandler(this.lblTxtContador_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(155, 489);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(17, 20);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "0";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(729, 308);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(177, 54);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar Numeros";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coloca la cantidad de numeros que deseas ordenar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(155, 129);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(144, 27);
            this.txtArray.TabIndex = 8;
            this.txtArray.TextChanged += new System.EventHandler(this.txtArray_TextChanged);
            // 
            // btnResizeArray
            // 
            this.btnResizeArray.Location = new System.Drawing.Point(155, 174);
            this.btnResizeArray.Name = "btnResizeArray";
            this.btnResizeArray.Size = new System.Drawing.Size(144, 52);
            this.btnResizeArray.TabIndex = 9;
            this.btnResizeArray.Text = "Ingresar Cantidad";
            this.btnResizeArray.UseVisualStyleBackColor = true;
            this.btnResizeArray.Click += new System.EventHandler(this.btnResizeArray_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(49, 30);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 31);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(729, 398);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 11;
            // 
            // NumerosIngresadosManualmente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 542);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnResizeArray);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblTxtContador);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnIngresar);
            this.Name = "NumerosIngresadosManualmente";
            this.Text = "NumerosIngresadosManualmente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblTxtContador;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnResizeArray;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblResultado;
    }
}