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
        public Interfaz()
        {
            InitializeComponent();
        }

        private void MensajeOk(string mensaje) {
            MessageBox.Show(mensaje, "Sistema de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Mostrar() {
            this.dataListado.DataSource = NMetodos.Mostrar();
            labelMostrar.Text = "Total de regirtros" + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarId() {
            this.dataListado.DataSource = NMetodos.BuscarId(int.Parse(txtBusquedaCategoria.Text));
            labelMostrar.Text = "Total de regirtros" + Convert.ToString(dataListado.Rows.Count);
        }

        private void tabRegistro_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
        }

        private void tabConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.BuscarId();
        }
    }
}
