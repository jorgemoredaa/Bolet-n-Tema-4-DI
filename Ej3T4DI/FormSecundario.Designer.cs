namespace Ej3T4DI
{
    partial class FormSecundario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajustardeformarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarSinDeformarZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustardeformarToolStripMenuItem,
            this.ajustarSinDeformarZoomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(347, 76);
            // 
            // ajustardeformarToolStripMenuItem
            // 
            this.ajustardeformarToolStripMenuItem.Name = "ajustardeformarToolStripMenuItem";
            this.ajustardeformarToolStripMenuItem.Size = new System.Drawing.Size(346, 36);
            this.ajustardeformarToolStripMenuItem.Text = "Ajustar (deformar)";
            this.ajustardeformarToolStripMenuItem.Click += new System.EventHandler(this.ajustardeformarToolStripMenuItem_Click);
            // 
            // ajustarSinDeformarZoomToolStripMenuItem
            // 
            this.ajustarSinDeformarZoomToolStripMenuItem.Name = "ajustarSinDeformarZoomToolStripMenuItem";
            this.ajustarSinDeformarZoomToolStripMenuItem.Size = new System.Drawing.Size(346, 36);
            this.ajustarSinDeformarZoomToolStripMenuItem.Text = "Ajustar sin deformar (Zoom)";
            this.ajustarSinDeformarZoomToolStripMenuItem.Click += new System.EventHandler(this.ajustarSinDeformarZoomToolStripMenuItem_Click);
            // 
            // FormSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSecundario";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajustardeformarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarSinDeformarZoomToolStripMenuItem;
    }
}