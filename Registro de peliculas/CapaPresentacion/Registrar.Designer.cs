namespace CapaPresentacion
{
    partial class Registrar
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstudio = new System.Windows.Forms.ComboBox();
            this.cbActor = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPeliculaId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.lbxGenero = new System.Windows.Forms.ListBox();
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.txtAgregarGenero = new System.Windows.Forms.TextBox();
            this.lbxActor = new System.Windows.Forms.ListBox();
            this.txtAgregarActor = new System.Windows.Forms.TextBox();
            this.btnAgregarActor = new System.Windows.Forms.Button();
            this.lbxEstudio = new System.Windows.Forms.ListBox();
            this.txtAgregarEstudio = new System.Windows.Forms.TextBox();
            this.btnAgregarEstudio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(42, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "IMDB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(280, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Actores";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(284, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Estudio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(284, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Genero";
            // 
            // cbEstudio
            // 
            this.cbEstudio.FormattingEnabled = true;
            this.cbEstudio.Location = new System.Drawing.Point(371, 245);
            this.cbEstudio.Name = "cbEstudio";
            this.cbEstudio.Size = new System.Drawing.Size(121, 21);
            this.cbEstudio.TabIndex = 26;
            // 
            // cbActor
            // 
            this.cbActor.FormattingEnabled = true;
            this.cbActor.Location = new System.Drawing.Point(367, 146);
            this.cbActor.Name = "cbActor";
            this.cbActor.Size = new System.Drawing.Size(121, 21);
            this.cbActor.TabIndex = 25;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(368, 50);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 24;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(297, 409);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 34);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(408, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(42, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID de la pelicula";
            // 
            // txtPeliculaId
            // 
            this.txtPeliculaId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPeliculaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeliculaId.Location = new System.Drawing.Point(171, 50);
            this.txtPeliculaId.Name = "txtPeliculaId";
            this.txtPeliculaId.Size = new System.Drawing.Size(61, 20);
            this.txtPeliculaId.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(45, 281);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 88);
            this.txtDescripcion.TabIndex = 16;
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCategoriaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoriaId.Location = new System.Drawing.Point(141, 191);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(91, 20);
            this.txtCategoriaId.TabIndex = 15;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Location = new System.Drawing.Point(96, 124);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(136, 20);
            this.txtAno.TabIndex = 14;
            // 
            // txtIMDB
            // 
            this.txtIMDB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIMDB.Location = new System.Drawing.Point(104, 157);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(128, 20);
            this.txtIMDB.TabIndex = 13;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCalificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalificacion.Location = new System.Drawing.Point(141, 227);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(91, 20);
            this.txtCalificacion.TabIndex = 12;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Location = new System.Drawing.Point(104, 92);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(128, 20);
            this.txtTitulo.TabIndex = 11;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(42, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(42, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CategoriaId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion de la pelicula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(186, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // lbxGenero
            // 
            this.lbxGenero.FormattingEnabled = true;
            this.lbxGenero.Location = new System.Drawing.Point(368, 77);
            this.lbxGenero.Name = "lbxGenero";
            this.lbxGenero.Size = new System.Drawing.Size(120, 56);
            this.lbxGenero.TabIndex = 30;
            this.lbxGenero.SelectedIndexChanged += new System.EventHandler(this.lbxGenero_SelectedIndexChanged);
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarGenero.Location = new System.Drawing.Point(504, 48);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(88, 23);
            this.btnAgregarGenero.TabIndex = 31;
            this.btnAgregarGenero.Text = "Agregar";
            this.btnAgregarGenero.UseVisualStyleBackColor = false;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // txtAgregarGenero
            // 
            this.txtAgregarGenero.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAgregarGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgregarGenero.Location = new System.Drawing.Point(504, 77);
            this.txtAgregarGenero.Name = "txtAgregarGenero";
            this.txtAgregarGenero.Size = new System.Drawing.Size(88, 20);
            this.txtAgregarGenero.TabIndex = 32;
            // 
            // lbxActor
            // 
            this.lbxActor.FormattingEnabled = true;
            this.lbxActor.Location = new System.Drawing.Point(367, 173);
            this.lbxActor.Name = "lbxActor";
            this.lbxActor.Size = new System.Drawing.Size(120, 56);
            this.lbxActor.TabIndex = 33;
            // 
            // txtAgregarActor
            // 
            this.txtAgregarActor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAgregarActor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgregarActor.Location = new System.Drawing.Point(504, 177);
            this.txtAgregarActor.Name = "txtAgregarActor";
            this.txtAgregarActor.Size = new System.Drawing.Size(88, 20);
            this.txtAgregarActor.TabIndex = 35;
            // 
            // btnAgregarActor
            // 
            this.btnAgregarActor.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarActor.Location = new System.Drawing.Point(504, 148);
            this.btnAgregarActor.Name = "btnAgregarActor";
            this.btnAgregarActor.Size = new System.Drawing.Size(88, 23);
            this.btnAgregarActor.TabIndex = 34;
            this.btnAgregarActor.Text = "Agregar";
            this.btnAgregarActor.UseVisualStyleBackColor = false;
            this.btnAgregarActor.Click += new System.EventHandler(this.btnAgregarActor_Click);
            // 
            // lbxEstudio
            // 
            this.lbxEstudio.FormattingEnabled = true;
            this.lbxEstudio.Location = new System.Drawing.Point(372, 272);
            this.lbxEstudio.Name = "lbxEstudio";
            this.lbxEstudio.Size = new System.Drawing.Size(120, 56);
            this.lbxEstudio.TabIndex = 36;
            // 
            // txtAgregarEstudio
            // 
            this.txtAgregarEstudio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAgregarEstudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgregarEstudio.Location = new System.Drawing.Point(504, 272);
            this.txtAgregarEstudio.Name = "txtAgregarEstudio";
            this.txtAgregarEstudio.Size = new System.Drawing.Size(88, 20);
            this.txtAgregarEstudio.TabIndex = 38;
            // 
            // btnAgregarEstudio
            // 
            this.btnAgregarEstudio.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarEstudio.Location = new System.Drawing.Point(504, 243);
            this.btnAgregarEstudio.Name = "btnAgregarEstudio";
            this.btnAgregarEstudio.Size = new System.Drawing.Size(88, 23);
            this.btnAgregarEstudio.TabIndex = 37;
            this.btnAgregarEstudio.Text = "Agregar";
            this.btnAgregarEstudio.UseVisualStyleBackColor = false;
            this.btnAgregarEstudio.Click += new System.EventHandler(this.btnAgregarEstudio_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAgregarEstudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarEstudio);
            this.Controls.Add(this.txtPeliculaId);
            this.Controls.Add(this.lbxEstudio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtAgregarActor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarActor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxActor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAgregarGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregarGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbxGenero);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.cbEstudio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cbActor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Registrar";
            this.Text = ".:.Interfaz.:.";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCategoriaId;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtPeliculaId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstudio;
        private System.Windows.Forms.ComboBox cbActor;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtAgregarEstudio;
        private System.Windows.Forms.Button btnAgregarEstudio;
        private System.Windows.Forms.ListBox lbxEstudio;
        private System.Windows.Forms.TextBox txtAgregarActor;
        private System.Windows.Forms.Button btnAgregarActor;
        private System.Windows.Forms.ListBox lbxActor;
        private System.Windows.Forms.TextBox txtAgregarGenero;
        private System.Windows.Forms.Button btnAgregarGenero;
        private System.Windows.Forms.ListBox lbxGenero;
    }
}