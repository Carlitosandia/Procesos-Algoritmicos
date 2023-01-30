
namespace ProyectoFinalAlgoritmos
{
    partial class OrdenacionRadixSort
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnResizeArray = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTxtContador = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(131, 12);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 31);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnResizeArray
            // 
            this.btnResizeArray.Location = new System.Drawing.Point(237, 156);
            this.btnResizeArray.Name = "btnResizeArray";
            this.btnResizeArray.Size = new System.Drawing.Size(144, 52);
            this.btnResizeArray.TabIndex = 19;
            this.btnResizeArray.Text = "Ingresar Cantidad";
            this.btnResizeArray.UseVisualStyleBackColor = true;
            this.btnResizeArray.Click += new System.EventHandler(this.btnResizeArray_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(237, 111);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(144, 27);
            this.txtArray.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Coloca la cantidad de numeros que deseas ordenar";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(836, 333);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(177, 54);
            this.btnOrdenar.TabIndex = 16;
            this.btnOrdenar.Text = "Ordenar Numeros";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(237, 471);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(17, 20);
            this.lblContador.TabIndex = 15;
            this.lblContador.Text = "0";
            // 
            // lblTxtContador
            // 
            this.lblTxtContador.AutoSize = true;
            this.lblTxtContador.Location = new System.Drawing.Point(237, 425);
            this.lblTxtContador.Name = "lblTxtContador";
            this.lblTxtContador.Size = new System.Drawing.Size(156, 20);
            this.lblTxtContador.TabIndex = 14;
            this.lblTxtContador.Text = "Contador de Numeros";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(237, 223);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(214, 20);
            this.lblInstrucciones.TabIndex = 13;
            this.lblInstrucciones.Text = "Ingresa los numeros, uno a uno";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(237, 272);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(158, 27);
            this.txtNumero.TabIndex = 12;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(237, 329);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(158, 58);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar Numero";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(907, 425);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 21;
            // 
            // OrdenacionRadixSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 522);
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
            this.Name = "OrdenacionRadixSort";
            this.Text = "OrdenacionRadixSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResizeArray;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTxtContador;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblResultado;
    }
}