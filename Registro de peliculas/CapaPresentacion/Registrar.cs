using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Registrar : System.Windows.Forms.Form
    {
        private bool NuevoEditar=false;
        private Peliculas pelicula = new Peliculas();
        public Generos genero = new Generos();
        public Actores actor = new Actores();
        public Estudios estudio = new Estudios();

        public Registrar()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtTitulo, "Ingrese el titulo de la pelicula");
        }

        private void MensajeOk(string mensaje) {
            MessageBox.Show(mensaje, "Sistema de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar() {
            txtTitulo.Clear();
            txtPeliculaId.Clear();
            txtIMDB.Clear();
            txtCategoriaId.Clear();
            txtDescripcion.Clear();
            txtCalificacion.Clear();
            txtAno.Clear();
        }
        private void Habilitar(bool valor) {
            this.txtPeliculaId.ReadOnly = !valor;
            this.txtTitulo.ReadOnly = !valor;
            this.txtIMDB.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtCalificacion.ReadOnly = !valor;
            this.txtAno.ReadOnly = !valor;
            this.txtCategoriaId.ReadOnly = !valor;
        }

      

        private void tabRegistro_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Habilitar(true);
            this.Botones();
        }

        private void tabConsulta_Click(object sender, EventArgs e)
        {

        }


        private void DescripcionPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (this.txtTitulo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos");
                    errorIcono.SetError(txtTitulo, "Ingrese un titulo");

                }
                else {
                    if (!this.NuevoEditar) {
                        pelicula.Titulo = txtTitulo.Text;
                        pelicula.Descripcion = txtDescripcion.Text;
                        pelicula.IMDB = int.Parse(txtIMDB.Text);
                        pelicula.Calificacion = int.Parse(txtCalificacion.Text);
                        pelicula.CategoriaId = int.Parse(txtCategoriaId.Text);
                        pelicula.Ano = int.Parse(txtAno.Text);

                        if (pelicula.Insertar())
                        {
                            Limpiar();
                            MensajeOk("Se inserto de forma correcta el registro");
                        }
                        else { MensajeError("No se a podido Ingresar el registro"); }
                    }
                    else
                    {
                        pelicula.Titulo = txtTitulo.Text;
                        pelicula.Descripcion = txtDescripcion.Text;
                        pelicula.Calificacion = int.Parse(txtCalificacion.Text);
                        pelicula.CategoriaId = int.Parse(txtCategoriaId.Text);
                        pelicula.IMDB = int.Parse(txtIMDB.Text);
                        pelicula.Ano = int.Parse(txtAno.Text);
                        pelicula.Editar();
                        Limpiar();
                        MensajeOk("Se actualizo de forma correcta el registro");
                    }
  
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBusquedaCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
          
        }

     
        private void Botones() {
            if(txtTitulo.Text!="")
            {
                this.Habilitar(true);
                
                this.btnGuardar.Enabled = true;
             
                
            }
            else
            {
                this.btnGuardar.Enabled = false;
           
            }
        }

 

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtPeliculaId.Text.Equals(""))
            {
                
                this.Habilitar(true);
                this.Botones();
            }
            else {
                MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }

        

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

      

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            Botones();
        }

        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            genero.Descripcion = txtAgregarGenero.Text;
         
            if (genero.Insertar()) {
                txtAgregarGenero.Clear();
            }
        }

        private void btnAgregarActor_Click(object sender, EventArgs e)
        {
            actor.Nombre = txtAgregarActor.Text;
            if (actor.Insertar()) {
                txtAgregarActor.Clear();
            }
        }

        private void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            estudio.Nombre = txtAgregarEstudio.Text;
            if (estudio.Insertar()) {
                txtAgregarEstudio.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pelicula.Buscar(int.Parse(txtPeliculaId.Text));
        }

        private void lbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
