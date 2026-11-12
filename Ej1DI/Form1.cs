using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ej1DI
{
    public partial class Form1 : Form
    {
        private string tituloOriginal;
        public Form1()
        {
            InitializeComponent();
            tituloOriginal = this.Text;
            button1.MouseMove += new MouseEventHandler(Form1_MouseMove);
            button2.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.KeyPreview = true;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            int ancho = 70;
            int alto = 30;
            int margenX = 20;
            int margenY = 120;
            int contador = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button nuevoBoton = new Button();
                    nuevoBoton.Text = contador.ToString();
                    contador++;
                    nuevoBoton.Width = ancho;
                    nuevoBoton.Height = alto;
                    nuevoBoton.Left = margenX + (i * ancho);
                    nuevoBoton.Top = margenY + (j * alto);

                    nuevoBoton.MouseMove += new MouseEventHandler(Form1_MouseMove);

                    nuevoBoton.MouseDown += new MouseEventHandler(NuevoBoton_MouseDown);
                    nuevoBoton.MouseUp += new MouseEventHandler(NuevoBoton_MouseUp);

                    this.Controls.Add(nuevoBoton);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (sender is Control control && control != this)
            {
                x += control.Left;
                y += control.Top;
            }

            this.Text = $"x: {x}; y: {y}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = tituloOriginal;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Green;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;

            } else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = tituloOriginal;
            }
            else
            {
                this.Text = "Tecla: " + e.KeyCode.ToString();
            }
        }

        private void NuevoBoton_MouseDown(object sender, MouseEventArgs e)
        {
            Button botonPulsado = sender as Button;
            if (botonPulsado != null)
            {
                botonPulsado.ForeColor = Color.Red;
            }
        }

        private void NuevoBoton_MouseUp(object sender, MouseEventArgs e)
        {
            Button botonSoltado = sender as Button;
            if (botonSoltado != null)
            {
                botonSoltado.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
