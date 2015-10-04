using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjercicios_cap_9
{
    public partial class TareaCap9 : Form
    {
        public struct Productos {
           
           public string nombre;
           public int precio;
           public string descripcion;

        }
        public struct Banco
        {

            public string nombre;
            public string cedula;
            public int montoCinta;
            public int numeroCuenta;

            public Banco(string nombre, string cedula,int  montoCinta, int numeroCuenta ) {

                this.cedula = cedula;
                this.nombre = nombre;
                this.montoCinta = montoCinta;
                this.numeroCuenta = numeroCuenta;
            }

        }
        public struct Mascota {
            private string tipo;
            private string raza;
            private string nombre;
            private int edad;

            public Mascota(string tipo, string raza, string nombre, int edad)
            {
                this.tipo = tipo;
                this.raza = raza;
                this.nombre = nombre;
                this.edad = edad;
            }
        }
        public struct Dueño {
            private string nombre;
            private string apellido;
            private int edad;
            private Mascota mascota;

            public Dueño(string nombre, string apellido, int edad, string mTipo,string mRaza, string mNombre, int mEdad) {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                mascota = new Mascota(mTipo,mRaza,mNombre,mEdad);
                
            }

        }

        public Productos productos;
        public Dueño dueñoMascota;
        enum marca {APlus=1,Accelera, accelera,Achilles,achilles,Aeolus,aeolus,Alliance };
        enum tiposEstrellas { protoestrella=1,estrellaTTauri,estrellaDeSeguenciaPrincipal,giganteRoja,enanaBlanca,enanaRoja,estrellaSuperGigante};

        //CONSTRUCTOR DE LA CLASE
        public TareaCap9()
        {

            InitializeComponent();
            btnProcesar.Enabled = false;
            btnProcesar2.Enabled = false;
            btnProcesar3.Enabled = false;
            tiposEstrellas estrella=tiposEstrellas.protoestrella;
            marca neumaticos = marca.accelera;
            labelTexto2.Text = estrella.ToString();
            labelTexto.Text = neumaticos.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void HabilitarBotones()
        {
            if (txtNombreProducto.Text != "" && txtPrecioProducto.Text != "" && DescripcionProducto.Text != "")
            {
                btnProcesar.Enabled = true;

            }
            if (txtNombreDueño.Text != "" && txtApellidoDueño.Text != "" && txtEdadDueño.Text != "" && txtTipoMascota.Text != "" && txtRazaMascota.Text != "" && txtNombreMascota.Text != "" && txtEdadMascota.Text != "")
            {
                btnProcesar2.Enabled = true;

            }
            if (txtNumeroCuenta.Text != "" && txtDueno.Text != "" && txtMontocinta.Text != "" && txtCedula.Text != "") {
                btnProcesar3.Enabled = true;
            }


        }

    private void btnProcesar_Click(object sender, EventArgs e)
        {
            productos = new Productos();
            productos.nombre = txtNombreProducto.Text;
            productos.precio = int.Parse(txtPrecioProducto.Text);
            productos.descripcion = DescripcionProducto.Text;

            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            DescripcionProducto.Clear();
            btnProcesar.Enabled = false;
            MessageBox.Show("OK","Registro de productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void DescripcionProducto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TabProductos_Click(object sender, EventArgs e)
        {
            HabilitarBotones();
        }
        public void Limpiar() {
            txtEdadMascota.Clear();
            txtEdadDueño.Clear();
            txtApellidoDueño.Clear();
            txtNombreDueño.Clear();
            txtNombreMascota.Clear();
            txtRazaMascota.Clear();
            txtTipoMascota.Clear();
            txtCedula.Clear();
            txtDueno.Clear();
            txtMontocinta.Clear();
            txtNumeroCuenta.Clear();
        }


        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            dueñoMascota = new Dueño(txtNombreDueño.Text,txtApellidoDueño.Text,int.Parse(txtEdadDueño.Text),txtTipoMascota.Text,txtRazaMascota.Text,txtNombreMascota.Text,int.Parse(txtEdadMascota.Text));
            MessageBox.Show("OK", "Dueño/Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            btnProcesar2.Enabled = false;
        }

        private void tabMascotaDueño_Click(object sender, EventArgs e)
        {
            HabilitarBotones();
        }

        private void tabNeumaticos_Click(object sender, EventArgs e)
        {

        }

        private void TabBanco_Click(object sender, EventArgs e)
        {
            HabilitarBotones();
        }

        private void btnProcesar3_Click(object sender, EventArgs e)
        {
            Banco cuanta = new Banco(txtDueno.Text,txtCedula.Text, int.Parse(txtMontocinta.Text), int.Parse(txtNumeroCuenta.Text));
            btnProcesar3.Enabled = false;
            Limpiar();
            MessageBox.Show("OK", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
