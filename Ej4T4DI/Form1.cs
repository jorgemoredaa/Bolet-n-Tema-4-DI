using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej4T4DI
{
    public partial class Form1 : Form
    {
        private string tituloOriginal = "Ejercicio 4 - Gestión de Listas";
        private int indiceAnimacion = 0;
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btnAnhadir;
        }

        private void btnAnhadir_Click(object sender, EventArgs e)
        {
            string textoNuevo = textBox1.Text.Trim();

            if (textoNuevo != "")
            {
                if (!listBox1.Items.Contains(textoNuevo))
                {
                    listBox1.Items.Add(textoNuevo);

                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    textBox1.Clear();
                }
            }
        }

        private void rbtnEliminar1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEliminar1.Checked)
            {
                btnEliminar.Text = "Elimina de lista 1";

            }
        }

        private void rbtnEliminar2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEliminar2.Checked)
            {
                btnEliminar.Text = "Elimina de lista 2";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rbtnEliminar1.Checked)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
            else if (rbtnEliminar2.Checked)
            {
                if (listBox2.SelectedItem != null)
                {
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
        }

        private void rbtnTraspasar12_CheckedChanged(object sender, EventArgs e)
        {
            btnTraspasar.Text = "Traspasar de lista 1 a lista 2";
        }

        private void rbtnTraspasar21_CheckedChanged(object sender, EventArgs e)
        {
            btnTraspasar.Text = "Traspasar de lista 2 a lista 1";
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            if (rbtnTraspasar12.Checked)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    var elemento = listBox1.SelectedItems[i];

                    if (!listBox2.Items.Contains(elemento))
                    {
                        listBox2.Items.Add(elemento);
                    }
                    listBox1.Items.Remove(elemento);
                }
            }
            else if (rbtnTraspasar21.Checked)
            {
                if (listBox2.SelectedItem != null)
                {
                    var elemento = listBox2.SelectedItem;

                    if (!listBox1.Items.Contains(elemento))
                    {
                        listBox1.Items.Add(elemento);
                    }
                    listBox2.Items.Remove(elemento);
                }
            }
            ActualizarEtiquetasLista1();
        }


        private void ActualizarEtiquetasLista1()
        {
            int totalElementos = listBox1.Items.Count;
            lblContador.Text = "Cantidad de elementos: " + totalElementos;

            string indicesTexto = "";

            foreach (int index in listBox1.SelectedIndices)
            {
                indicesTexto += index + ", ";
            }
            lblIndices.Text = "Índices seleccionados: " + indicesTexto;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEtiquetasLista1();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tituloOriginal.Length > 0)
            {
                string ultimoCaracter = tituloOriginal.Substring(tituloOriginal.Length - 1);
                string resto = tituloOriginal.Substring(0, tituloOriginal.Length - 1);
                tituloOriginal = ultimoCaracter + resto;

                this.Text = tituloOriginal;
            }

            if (this.Icon == Properties.Resources.pythonIcon)
            {
                this.Icon = Properties.Resources.mouseIcon;
            }
            else
            {

            }
        }
    }
}
