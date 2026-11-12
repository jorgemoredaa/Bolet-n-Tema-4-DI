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

namespace Ej3T4DI
{
    public partial class Form1 : Form
    {
        private int segundosTotales = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog1.FileName;

                MessageBox.Show("Imágen seleccionada: " + rutaImagen);

                string soloNombreArchivo = Path.GetFileName(rutaImagen);

                FormSecundario form2 = new FormSecundario(rutaImagen, soloNombreArchivo);

                if (chkModal.Checked)
                {
                    form2.ShowDialog(this);
                }
                else
                {
                    form2.Show();
                }
            }
        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked)
            {
                chkModal.Text = "Modal";
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.Text = "No modal";
                chkModal.ForeColor = Color.Black;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundosTotales++;

            int minutos = segundosTotales / 60;
            int segundos = segundosTotales % 60;

            string tiempoFormateado = $"{minutos:D2}:{segundos:D2}";

            this.Text = $"Visor de imágenes - {tiempoFormateado}";
        }
    }
}
