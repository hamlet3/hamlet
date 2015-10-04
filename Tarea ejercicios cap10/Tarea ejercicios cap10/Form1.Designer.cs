namespace Tarea_ejercicios_cap10
{
    partial class TareaCap10
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
            this.tcTareacap10 = new System.Windows.Forms.TabControl();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tabPoligono = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTexto = new System.Windows.Forms.Label();
            this.tcTareacap10.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tabEstudiantes.SuspendLayout();
            this.tabPoligono.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTareacap10
            // 
            this.tcTareacap10.Controls.Add(this.tabInventario);
            this.tcTareacap10.Controls.Add(this.tabEstudiantes);
            this.tcTareacap10.Controls.Add(this.tabPoligono);
            this.tcTareacap10.Location = new System.Drawing.Point(1, 3);
            this.tcTareacap10.Name = "tcTareacap10";
            this.tcTareacap10.SelectedIndex = 0;
            this.tcTareacap10.Size = new System.Drawing.Size(287, 266);
            this.tcTareacap10.TabIndex = 0;
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.label1);
            this.tabInventario.Location = new System.Drawing.Point(4, 22);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(279, 240);
            this.tabInventario.TabIndex = 0;
            this.tabInventario.Text = "Clase inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            this.tabInventario.Click += new System.EventHandler(this.tabInventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Como dice el libro solo crear el diceño\r\n de la clase, mirar en el codigo";
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.btnIngresar);
            this.tabEstudiantes.Controls.Add(this.label5);
            this.tabEstudiantes.Controls.Add(this.label4);
            this.tabEstudiantes.Controls.Add(this.label3);
            this.tabEstudiantes.Controls.Add(this.txtApellido);
            this.tabEstudiantes.Controls.Add(this.txtNota);
            this.tabEstudiantes.Controls.Add(this.txtNumero);
            this.tabEstudiantes.Controls.Add(this.txtNombre);
            this.tabEstudiantes.Controls.Add(this.label2);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 22);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(279, 240);
            this.tabEstudiantes.TabIndex = 1;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            this.tabEstudiantes.Click += new System.EventHandler(this.tabEstudiantes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 81);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(110, 112);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nota";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(110, 161);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 33);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tabPoligono
            // 
            this.tabPoligono.Controls.Add(this.lbTexto);
            this.tabPoligono.Controls.Add(this.label8);
            this.tabPoligono.Controls.Add(this.txtAltura);
            this.tabPoligono.Controls.Add(this.txtBase);
            this.tabPoligono.Controls.Add(this.label7);
            this.tabPoligono.Controls.Add(this.btnProcesar);
            this.tabPoligono.Controls.Add(this.label6);
            this.tabPoligono.Location = new System.Drawing.Point(4, 22);
            this.tabPoligono.Name = "tabPoligono";
            this.tabPoligono.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoligono.Size = new System.Drawing.Size(279, 240);
            this.tabPoligono.TabIndex = 2;
            this.tabPoligono.Text = "Poligono";
            this.tabPoligono.UseVisualStyleBackColor = true;
            this.tabPoligono.Click += new System.EventHandler(this.tabPoligono_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(56, 142);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 38);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Altura";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(62, 42);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(69, 20);
            this.txtBase.TabIndex = 3;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(65, 90);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 20);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "=";
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Location = new System.Drawing.Point(164, 70);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(0, 13);
            this.lbTexto.TabIndex = 6;
            // 
            // TareaCap10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tcTareacap10);
            this.MaximizeBox = false;
            this.Name = "TareaCap10";
            this.Text = "Tarea cap 10";
            this.tcTareacap10.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.tabInventario.PerformLayout();
            this.tabEstudiantes.ResumeLayout(false);
            this.tabEstudiantes.PerformLayout();
            this.tabPoligono.ResumeLayout(false);
            this.tabPoligono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTareacap10;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPoligono;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Label label8;
    }
}

