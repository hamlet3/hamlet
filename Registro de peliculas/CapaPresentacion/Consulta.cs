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
    public partial class Consulta : Form
    {
        public Peliculas pelicula = new Peliculas();
        public Consulta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
           
        
        }

        public void Mostrar()
        {

            labelMostrar.Text = "Total de regirtros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataListado.DataSource = pelicula.Listado("*", "h=h", "ORDER BY Titulo");
        }
    }
    
}
