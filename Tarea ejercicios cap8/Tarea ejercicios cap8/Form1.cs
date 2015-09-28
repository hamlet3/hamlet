using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_ejercicios_cap8
{
    public partial class TareaCap8 : Form
    {
        string cadena;
        string tiempo;
        public TareaCap8()
        {
            InitializeComponent();
            btnMostrar.Enabled = false;
        }
        //cadena
        private void btnProcesar1_Click(object sender, EventArgs e)
        {
            labelCadena.Text = txtCadena.Text; 
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            labelCadena2.Text = txtCadena2.Text;
            btnMostrar.Enabled = true;
        }
        //Justificacion
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtDerecha.Text != "")
            {
                cadena = labelCadena2.Text.PadLeft(int.Parse(txtDerecha.Text));
                labelCadena2.Text = cadena;
            }
            if (txtIzquierda.Text != "")
            {//ni idea de por que no se mueve a la izquierda
                cadena = labelCadena2.Text.PadRight(int.Parse(txtIzquierda.Text));
                labelCadena2.Text = cadena;
            }
           
        }
        //Fecha
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            labelTiempo.Text = String.Format("La fecha es :{0:h:m:s tt} \n {0:dddd/ M /yyyy}", DateTime.Now); 
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float suma= float.Parse(txtNumero1.Text) + float.Parse(txtNumero2.Text);
            if (suma< 0)
            {
                labelSuma.Text = "(" + suma + ")";
            }
            else {
                labelSuma.Text =suma.ToString();
            }
        }
    }
}
