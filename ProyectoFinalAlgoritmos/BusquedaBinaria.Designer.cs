
namespace ProyectoFinalAlgoritmos
{
    partial class BusquedaBinaria
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTxtContador = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNumeroBuscado = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(111, 55);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 31);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "<--";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnResizeArray
            // 
            this.btnResizeArray.Location = new System.Drawing.Point(169, 204);
            this.btnResizeArray.Name = "btnResizeArray";
            this.btnResizeArray.Size = new System.Drawing.Size(144, 52);
            this.btnResizeArray.TabIndex = 23;
            this.btnResizeArray.Text = "Ingresar Cantidad";
            this.btnResizeArray.UseVisualStyleBackColor = true;
            this.btnResizeArray.Click += new System.EventHandler(this.btnResizeArray_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(169, 159);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(144, 27);
            this.txtArray.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Coloca la cantidad de numeros del arreglo donde se buscaran los datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingrese el numero que desea buscar";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(169, 517);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(17, 20);
            this.lblContador.TabIndex = 30;
            this.lblContador.Text = "0";
            // 
            // lblTxtContador
            // 
            this.lblTxtContador.AutoSize = true;
            this.lblTxtContador.Location = new System.Drawing.Point(169, 471);
            this.lblTxtContador.Name = "lblTxtContador";
            this.lblTxtContador.Size = new System.Drawing.Size(156, 20);
            this.lblTxtContador.TabIndex = 29;
            this.lblTxtContador.Text = "Contador de Numeros";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(169, 269);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(214, 20);
            this.lblInstrucciones.TabIndex = 28;
            this.lblInstrucciones.Text = "Ingresa los numeros, uno a uno";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(169, 318);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(158, 27);
            this.txtNumero.TabIndex = 27;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(169, 375);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(158, 58);
            this.btnIngresar.TabIndex = 26;
            this.btnIngresar.Text = "Ingresar Numero";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNumeroBuscado
            // 
            this.txtNumeroBuscado.Location = new System.Drawing.Point(791, 159);
            this.txtNumeroBuscado.Name = "txtNumeroBuscado";
            this.txtNumeroBuscado.Size = new System.Drawing.Size(138, 27);
            this.txtNumeroBuscado.TabIndex = 31;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(791, 204);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(138, 46);
            this.btnBusqueda.TabIndex = 32;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // BusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 566);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtNumeroBuscado);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblTxtContador);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnResizeArray);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaBinaria";
            this.Text = "BusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResizeArray;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTxtContador;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNumeroBuscado;
        private System.Windows.Forms.Button btnBusqueda;
    }
}