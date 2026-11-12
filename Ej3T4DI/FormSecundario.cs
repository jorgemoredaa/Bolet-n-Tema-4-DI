using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3T4DI
{
    public partial class FormSecundario : Form
    {
        public FormSecundario(string rutaRecibida, string nombreRecibido)
        {
            InitializeComponent();

            this.Text = nombreRecibido;

            Image imagenCreada = Image.FromFile(rutaRecibida);
            pictureBox1.Image = imagenCreada;
        }

        private void ajustardeformarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ajustarSinDeformarZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
