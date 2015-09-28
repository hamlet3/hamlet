namespace CapaPresentacion
{
    partial class Interfaz
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
            this.tcRegistroPeluculas = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.DescripcionPelicula = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.lbBusqueda = new System.Windows.Forms.ListBox();
            this.txtBusquedaCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMostrar = new System.Windows.Forms.Label();
            this.tcRegistroPeluculas.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRegistroPeluculas
            // 
            this.tcRegistroPeluculas.Controls.Add(this.tabRegistro);
            this.tcRegistroPeluculas.Controls.Add(this.tabBusqueda);
            this.tcRegistroPeluculas.Controls.Add(this.tabConsulta);
            this.tcRegistroPeluculas.Location = new System.Drawing.Point(12, 45);
            this.tcRegistroPeluculas.Name = "tcRegistroPeluculas";
            this.tcRegistroPeluculas.SelectedIndex = 0;
            this.tcRegistroPeluculas.Size = new System.Drawing.Size(485, 235);
            this.tcRegistroPeluculas.TabIndex = 6;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.DescripcionPelicula);
            this.tabRegistro.Controls.Add(this.label2);
            this.tabRegistro.Controls.Add(this.btnGuardar);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(477, 209);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registrar";
            this.tabRegistro.UseVisualStyleBackColor = true;
            this.tabRegistro.Click += new System.EventHandler(this.tabRegistro_Click);
            // 
            // DescripcionPelicula
            // 
            this.DescripcionPelicula.FormattingEnabled = true;
            this.DescripcionPelicula.Location = new System.Drawing.Point(3, 37);
            this.DescripcionPelicula.Name = "DescripcionPelicula";
            this.DescripcionPelicula.Size = new System.Drawing.Size(359, 95);
            this.DescripcionPelicula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion de la pelicula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(3, 154);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.lbBusqueda);
            this.tabBusqueda.Controls.Add(this.txtBusquedaCategoria);
            this.tabBusqueda.Controls.Add(this.label1);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(477, 209);
            this.tabBusqueda.TabIndex = 1;
            this.tabBusqueda.Text = "Buscar";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.FormattingEnabled = true;
            this.lbBusqueda.Location = new System.Drawing.Point(27, 98);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(234, 95);
            this.lbBusqueda.TabIndex = 2;
            // 
            // txtBusquedaCategoria
            // 
            this.txtBusquedaCategoria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBusquedaCategoria.Location = new System.Drawing.Point(27, 58);
            this.txtBusquedaCategoria.Name = "txtBusquedaCategoria";
            this.txtBusquedaCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por ID";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.labelMostrar);
            this.tabConsulta.Controls.Add(this.btnConsultar);
            this.tabConsulta.Controls.Add(this.dataListado);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(477, 209);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            this.tabConsulta.Click += new System.EventHandler(this.tabConsulta_Click);
            // 
            // dataListado
            // 
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            this.dataListado.Location = new System.Drawing.Point(0, 57);
            this.dataListado.Name = "dataListado";
            this.dataListado.Size = new System.Drawing.Size(477, 150);
            this.dataListado.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(6, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 30);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // labelMostrar
            // 
            this.labelMostrar.AutoSize = true;
            this.labelMostrar.Location = new System.Drawing.Point(304, 30);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(35, 13);
            this.labelMostrar.TabIndex = 2;
            this.labelMostrar.Text = "label3";
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 301);
            this.Controls.Add(this.tcRegistroPeluculas);
            this.Name = "Interfaz";
            this.Text = ".:.Interfaz.:.";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.tcRegistroPeluculas.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.tabBusqueda.ResumeLayout(false);
            this.tabBusqueda.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRegistroPeluculas;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.ListBox DescripcionPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.ListBox lbBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Label labelMostrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}