using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2T4DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Selector RGB y visor de imágenes";
            this.CancelButton = btnSalir;
            this.AcceptButton = btnColor;
        }

        private void btnSalir_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool esValidoR = int.TryParse(txtBox1.Text, out int R);
            bool esValidoG = int.TryParse(txtBox2.Text, out int G);
            bool esValidoB = int.TryParse(txtBox3.Text, out int B);

            if (esValidoR && esValidoG && esValidoB)
            {
                if (R >= 0 && R <= 255 && G >= 0 && G <= 255 && B >= 0 && B <= 255)
                {
                    this.BackColor = Color.FromArgb(R, G, B);
                }
                else
                {
                    MessageBox.Show("Los valores RGB deben estar compredidos entre 0 y 255.",
                           "Atención", 
                           MessageBoxButtons.OK, 
                           MessageBoxIcon.Warning
                           );
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = txtPath.Text.Trim();

                if (File.Exists(ruta))
                {
                    pictureBox1.BackgroundImage = Image.FromFile(ruta);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("El archivo de imagen no existe en esta ruta.",
                                    "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            catch (IOException ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen.",
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos para acceder a la imágen.",
                    "Faltan permisos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void AsignarBotonColor(object sender, EventArgs e) {
            this.AcceptButton = btnColor;
        }

        private void AsignarBotonImagen(object sender, EventArgs e)
        {
            this.AcceptButton = btnCargar;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txtB)
                {
                    if (txtB.Tag != null && txtB.Tag.ToString() == "color")
                    {
                        txtB.Text = "0";
                    }
                    else if (txtB.Tag != null && txtB.Tag.ToString() == "path")
                    {
                        txtB.Text = "";
                    }
                }    
            }

            this.BackgroundImage = null;
            pictureBox1.BackgroundImage = null;
            this.BackColor = Color.Empty;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                boton.BackColor = Color.Red;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                boton.BackColor = SystemColors.Control;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
