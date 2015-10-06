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
    public partial class Interfaz : System.Windows.Forms.Form
    {
        private bool esNuevo=false;
        private bool esEditar=false;

        public Interfaz()
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
            txtIdPelicula.Clear();
            txtIMDB.Clear();
            txtIdCategoria.Clear();
            txtDescripcion.Clear();
            txtCalificacion.Clear();
            txtAno.Clear();
        }
        private void Habilitar(bool valor) {
            this.txtIdPelicula.ReadOnly = !valor;
            this.txtTitulo.ReadOnly = !valor;
            this.txtIMDB.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtCalificacion.ReadOnly = !valor;
            this.txtAno.ReadOnly = !valor;
            this.txtIdCategoria.ReadOnly = !valor;
        }

        private void OcultarColumnas() {
            this.dataListado.Columns[0].Visible = false;
        }
        public void Mostrar() {
            this.dataListado.DataSource = NMetodos.Mostrar();
            labelMostrar.Text = "Total de regirtros: " + Convert.ToString(dataListado.Rows.Count);
            OcultarColumnas();
        }
        private void BuscarTitulo() {
            this.dataListado.DataSource = NMetodos.BuscarTitulo(this.txtBuscarTitulo.Text);
            labelMostrar.Text = "Total de regirtros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void tabRegistro_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void tabConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.BuscarTitulo();
        }

        private void DescripcionPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtTitulo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos");
                    errorIcono.SetError(txtTitulo, "Ingrese un titulo");

                }
                else {
                    if (this.esNuevo) {
                        respuesta = NMetodos.Incertar(txtTitulo.Text.Trim().ToUpper(),txtDescripcion.Text.Trim().ToUpper(),int.Parse(txtIdCategoria.Text),int.Parse(txtIMDB.Text),int.Parse(txtAno.Text),int.Parse(txtCalificacion.Text));
                    }
                    else
                    {
                        respuesta = NMetodos.Editar(int.Parse(txtIdPelicula.Text),txtTitulo.Text.Trim().ToUpper(), txtDescripcion.Text.Trim().ToUpper(), int.Parse(txtIdCategoria.Text), int.Parse(txtIMDB.Text), int.Parse(txtAno.Text), int.Parse(txtCalificacion.Text));
                     }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.esNuevo)
                        {
                            this.MensajeOk("Se incerto de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizo de forma correcta el registro");
                        }
                    }
                    else {
                        this.MensajeError(respuesta);
                    }
                    this.esNuevo = false;
                    this.esEditar = false;
                    this.Botones();
                    this.Mostrar();
                    this.Limpiar();
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
            this.BuscarTitulo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.esEditar = false;
            this.esNuevo = false;
            this.Botones();
            this.Habilitar(false);
            this.Limpiar();
        }
        private void Botones() {
            if(this.esNuevo || this.esEditar)
            {
                this.Habilitar(true);
                this.btnNuevo . Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.esNuevo = true;
            this.esEditar = false;
            this.Habilitar(true);
            this.Botones();
            this.Limpiar();
            this.txtTitulo.Focus();
        }

        private void dataListado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.txtIdPelicula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_pelicula"].Value);
            this.txtTitulo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["titulo"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            this.txtIdCategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_categoria"].Value);
            this.txtIMDB.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IMDB"].Value);
            this.txtAno.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["ano"].Value);
            this.txtCalificacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["calificacion"].Value);

            this.tcRegistroPeluculas.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdPelicula.Text.Equals(""))
            {
                this.esEditar = true;
                this.Habilitar(true);
                this.Botones();
            }
            else {
                MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminar.Checked)
            {
                dataListado.Columns[0].Visible = true;
            }
            else {
                dataListado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index) {
                DataGridViewCheckBoxCell ChekEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChekEliminar.Value = !Convert.ToBoolean(ChekEliminar.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                string Codigo;
                foreach (DataGridViewRow row in dataListado.Rows) {
                    if (Convert.ToBoolean(row.Cells[0].Value)) {
                        Codigo = Convert.ToString(row.Cells[1].Value);
                        respuesta = NMetodos.Eliminar(Convert.ToInt32(Codigo));

                        if (respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Se Elimino correctamente el registro");

                        }
                        else {
                            this.MensajeError(respuesta);
                        }
                    }
                }
                this.Mostrar();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
