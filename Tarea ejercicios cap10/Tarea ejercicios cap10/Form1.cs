using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_ejercicios_cap10
{
   
    public partial class TareaCap10 : Form
    {
        //Ejercicio #1
        public class Inventario
        {
            private string articulos;
            private string descriocionArticulo;
            private int codigo;
            private int precio;
        }
        //Ejercicio #2
        public class Estudiante
        {
            private string nombre;
            private string apellido;
            private int notas;
            private int numero;

            public Estudiante(string nombre, string apellido, int notas, int numero)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.notas = notas;
                this.numero = numero;
            }

        }

        //Ejercicio #3
        public class Poligono
        {
            public float altura;
            private float _base;
            

            public Poligono() { }

            public Poligono(float altura, float _base) {
                this.altura = Altura;
                this._base = Base;
            }
            //ejercicio #4
            public float Altura {
                
                get { return altura; }
                set {
                     if (altura<=0) {
                        altura = value;
                    }
                }


        }

            public float Base {
                get { return altura; }
                set {
                    if (altura <= 0)
                    {
                        _base = value;
                    }
                }
            }

            public override string ToString()
            {
                string mensaje = "";
                mensaje += "Nose por que da 0 : " + Altura.ToString()+ Base.ToString();
                return mensaje;
            }

        }
        public TareaCap10()
        {
            InitializeComponent();
            btnIngresar.Enabled = false;
            btnProcesar.Enabled = false;
        }
        private void Mensaje() {
            MessageBox.Show("OK", "Datos de estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante(txtNombre.Text,txtApellido.Text,int.Parse(txtNota.Text),int.Parse(txtNumero.Text));
            txtNombre.Clear();
            txtApellido.Clear();
            txtNota.Clear();
            txtNumero.Clear();
            btnIngresar.Enabled=false;
            Mensaje();
        }

        private void tabEstudiantes_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!="" && txtApellido.Text!="" && txtNota.Text!="" && txtNumero.Text!="") {
                btnIngresar.Enabled = true;
            }
        }

        private void tabPoligono_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Poligono figura = new Poligono(float.Parse(txtAltura.Text),float.Parse(txtBase.Text));
            lbTexto.Text =figura.ToString() ;
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            if (txtAltura.Text != "" && txtBase.Text!="") {
                btnProcesar.Enabled = true;
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if (txtAltura.Text != "" && txtBase.Text != "")
            {
                btnProcesar.Enabled = true;
            }
        }
    }
}
