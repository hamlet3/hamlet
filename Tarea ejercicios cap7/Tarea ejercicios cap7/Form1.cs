using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Tarea_ejercicios_cap7
{
    public partial class TareaCap7 : Form
    {
        ArrayList estudiantes = new ArrayList();
        ArrayList gastosDecendente = new ArrayList();
        Hashtable diccionario = new Hashtable();
        Hashtable agenda = new Hashtable();
        float promedio=0;
        int dias = 30;
        float sumaGastos=0;
        float mayor=-1, menor=999;
        public TareaCap7()
        {
            InitializeComponent();
            diccionario.Add("Arbol", " Planta perenne, de tronco leñoso y elevado, que se ramifica a cierta altura del suelo.");
            diccionario.Add("Acero", "Aleación de hierro y carbono, en diferentes proporciones, que, según su tratamiento, adquiere especial elasticidad, dureza o resistencia.");
            diccionario.Add("Avenar","Drenar,desaguar");
            diccionario.Add("Dibujo", "Delineación, figura o imagen ejecutada en claro y oscuro, que toma nombre del material con que se hace. Dibujo de carbón, de lápiz.");
            diccionario.Add("Arte", "Virtud, disposición y habilidad para hacer algo.");
            diccionario.Add("Musica", "Composición en verso, que se canta, o hecha a propósito para que se pueda poner en música.");
            diccionario.Add("Danzar", "Dicho de una persona: bailar (ejecutar movimientos acompasados).");

        }
        
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
            txtNotas.Enabled = false;
            foreach (int x in estudiantes) {
                if (x > mayor)
                {
                    mayor = x;
                }
                if (x < menor)
                {
                    menor = x;
                }
                promedio += x;
            }
            promedio /= estudiantes.Count;
            labelMayor.Text = mayor.ToString();
            labelMenor.Text = menor.ToString();
            labelPromedio.Text = promedio.ToString();
        }

        private void tabSalonCLases_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            foreach(DictionaryEntry x in diccionario)
            {
                //No se por que no compara bien o.o
                if (txtBusqueda.Text== x.Key.ToString()) {
                    labelDescripcion.Text = x.Value.ToString();
                }
                else
                {
                    labelDescripcion.Text = "No se ha encontrado esta palabra en el dicionario";
                }

            }
            
        }
        //Agenda telefonica
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtNombre.Text == "")
            {
                labelTexto2.Text = "INTRODUSCA EL NOMBRE Y EL NUMERO DE LA PERSONA";
            }
            else
            {
                labelTexto2.Text = "";
                agenda.Add(txtNombre.Text, txtNumero.Text);
                txtNombre.Clear();
                txtNumero.Clear();
                txtNombre.Focus();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach(DictionaryEntry x in agenda)
            {
                
                listBoxAgenda.Items.Add(x.Key.ToString()+"  " + x.Value.ToString()); 
                 
            }
        }
        //Suma de gstos
        private void btnIncertar_Click(object sender, EventArgs e)
        {
            if (txtGastos.Text != "")
            {
                if (dias != 0)
                {
                    dias--;
                    gastosDecendente.Add(float.Parse(txtGastos.Text));
                    labelTexto3.Text = "Gastos " + dias + " dias";
                    txtGastos.Clear();
                    txtGastos.Focus();
                }
                else
                {
                    foreach (int x in gastosDecendente) {

                    }
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNotas.Text == "")
            {
                labelTexto.Text = "INTRODUSCA LA NODA DEL ESTUDIANTE";

            }
            else
            {
                if (int.Parse(txtNotas.Text) < -1 || int.Parse(txtNotas.Text) > 100)
                {
                    labelTexto.Text = "La nota debe ser de 1 a 100";
                }
                else
                {
                    labelTexto.Text = "Notas de estudiantes";
                    estudiantes.Add(int.Parse(txtNotas.Text));
                    txtNotas.Clear();
                    txtNotas.Focus();

                }
            }
        }
    }
}
