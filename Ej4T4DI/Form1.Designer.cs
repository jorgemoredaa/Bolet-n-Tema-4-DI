namespace Ej4T4DI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.rbtnEliminar1 = new System.Windows.Forms.RadioButton();
            this.rbtnEliminar2 = new System.Windows.Forms.RadioButton();
            this.rbtnTraspasar12 = new System.Windows.Forms.RadioButton();
            this.rbtnTraspasar21 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(183, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(146, 100);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(571, 59);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(146, 100);
            this.listBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 29);
            this.textBox1.TabIndex = 2;
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Location = new System.Drawing.Point(32, 193);
            this.btnAnhadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(221, 40);
            this.btnAnhadir.TabIndex = 3;
            this.btnAnhadir.Text = "Añadir";
            this.btnAnhadir.UseVisualStyleBackColor = true;
            this.btnAnhadir.Click += new System.EventHandler(this.btnAnhadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(32, 263);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(221, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(32, 336);
            this.btnTraspasar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(221, 89);
            this.btnTraspasar.TabIndex = 5;
            this.btnTraspasar.Text = "Traspasar";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(313, 234);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(64, 25);
            this.lblContador.TabIndex = 6;
            this.lblContador.Text = "label1";
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.Location = new System.Drawing.Point(313, 336);
            this.lblIndices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(64, 25);
            this.lblIndices.TabIndex = 7;
            this.lblIndices.Text = "label2";
            // 
            // rbtnEliminar1
            // 
            this.rbtnEliminar1.AutoSize = true;
            this.rbtnEliminar1.Location = new System.Drawing.Point(593, 203);
            this.rbtnEliminar1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnEliminar1.Name = "rbtnEliminar1";
            this.rbtnEliminar1.Size = new System.Drawing.Size(172, 29);
            this.rbtnEliminar1.TabIndex = 8;
            this.rbtnEliminar1.TabStop = true;
            this.rbtnEliminar1.Text = "Borrar de lista 1";
            this.rbtnEliminar1.UseVisualStyleBackColor = true;
            this.rbtnEliminar1.CheckedChanged += new System.EventHandler(this.rbtnEliminar1_CheckedChanged);
            // 
            // rbtnEliminar2
            // 
            this.rbtnEliminar2.AutoSize = true;
            this.rbtnEliminar2.Location = new System.Drawing.Point(593, 271);
            this.rbtnEliminar2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnEliminar2.Name = "rbtnEliminar2";
            this.rbtnEliminar2.Size = new System.Drawing.Size(172, 29);
            this.rbtnEliminar2.TabIndex = 9;
            this.rbtnEliminar2.TabStop = true;
            this.rbtnEliminar2.Text = "Borrar de lista 2";
            this.rbtnEliminar2.UseVisualStyleBackColor = true;
            this.rbtnEliminar2.CheckedChanged += new System.EventHandler(this.rbtnEliminar2_CheckedChanged);
            // 
            // rbtnTraspasar12
            // 
            this.rbtnTraspasar12.AutoSize = true;
            this.rbtnTraspasar12.Location = new System.Drawing.Point(593, 346);
            this.rbtnTraspasar12.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTraspasar12.Name = "rbtnTraspasar12";
            this.rbtnTraspasar12.Size = new System.Drawing.Size(279, 29);
            this.rbtnTraspasar12.TabIndex = 10;
            this.rbtnTraspasar12.TabStop = true;
            this.rbtnTraspasar12.Text = "Traspasar de lista 1 a lista 2";
            this.rbtnTraspasar12.UseVisualStyleBackColor = true;
            this.rbtnTraspasar12.CheckedChanged += new System.EventHandler(this.rbtnTraspasar12_CheckedChanged);
            // 
            // rbtnTraspasar21
            // 
            this.rbtnTraspasar21.AutoSize = true;
            this.rbtnTraspasar21.Location = new System.Drawing.Point(593, 431);
            this.rbtnTraspasar21.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTraspasar21.Name = "rbtnTraspasar21";
            this.rbtnTraspasar21.Size = new System.Drawing.Size(279, 29);
            this.rbtnTraspasar21.TabIndex = 11;
            this.rbtnTraspasar21.TabStop = true;
            this.rbtnTraspasar21.Text = "Traspasar de lista 2 a lista 1";
            this.rbtnTraspasar21.UseVisualStyleBackColor = true;
            this.rbtnTraspasar21.CheckedChanged += new System.EventHandler(this.rbtnTraspasar21_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 540);
            this.Controls.Add(this.rbtnTraspasar21);
            this.Controls.Add(this.rbtnTraspasar12);
            this.Controls.Add(this.rbtnEliminar2);
            this.Controls.Add(this.rbtnEliminar1);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.RadioButton rbtnEliminar1;
        private System.Windows.Forms.RadioButton rbtnEliminar2;
        private System.Windows.Forms.RadioButton rbtnTraspasar12;
        private System.Windows.Forms.RadioButton rbtnTraspasar21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

