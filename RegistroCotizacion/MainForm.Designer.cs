namespace RegistroCotizacion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ArticulostoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PersonastoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CotizaciontoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.CotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticulosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PersonasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CotizacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulostoolStripButton,
            this.toolStripSeparator1,
            this.PersonastoolStripButton,
            this.CotizaciontoolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(433, 27);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip";
            // 
            // ArticulostoolStripButton
            // 
            this.ArticulostoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ArticulostoolStripButton.Image")));
            this.ArticulostoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArticulostoolStripButton.Name = "ArticulostoolStripButton";
            this.ArticulostoolStripButton.Size = new System.Drawing.Size(78, 24);
            this.ArticulostoolStripButton.Text = "Articulos";
            this.ArticulostoolStripButton.Click += new System.EventHandler(this.ArticulostoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // PersonastoolStripButton
            // 
            this.PersonastoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PersonastoolStripButton.Image")));
            this.PersonastoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PersonastoolStripButton.Name = "PersonastoolStripButton";
            this.PersonastoolStripButton.Size = new System.Drawing.Size(78, 24);
            this.PersonastoolStripButton.Text = "Personas";
            this.PersonastoolStripButton.Click += new System.EventHandler(this.PersonastoolStripButton_Click);
            // 
            // CotizaciontoolStripButton
            // 
            this.CotizaciontoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CotizaciontoolStripButton.Image")));
            this.CotizaciontoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CotizaciontoolStripButton.Name = "CotizaciontoolStripButton";
            this.CotizaciontoolStripButton.Size = new System.Drawing.Size(87, 24);
            this.CotizaciontoolStripButton.Text = "Cotizacion";
            this.CotizaciontoolStripButton.Click += new System.EventHandler(this.CotizaciontoolStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.PersonasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.CotizacionToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // ArticulosToolStripMenuItem
            // 
            this.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem";
            this.ArticulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ArticulosToolStripMenuItem.Text = "Registrar Articulos";
            this.ArticulosToolStripMenuItem.Click += new System.EventHandler(this.ArticulosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // PersonasToolStripMenuItem
            // 
            this.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem";
            this.PersonasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PersonasToolStripMenuItem.Text = "Registrar Personas";
            this.PersonasToolStripMenuItem.Click += new System.EventHandler(this.PersonasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // CotizacionToolStripMenuItem
            // 
            this.CotizacionToolStripMenuItem.Name = "CotizacionToolStripMenuItem";
            this.CotizacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CotizacionToolStripMenuItem.Text = "Registrar Cotizacion";
            this.CotizacionToolStripMenuItem.Click += new System.EventHandler(this.CotizacionToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosToolStripMenuItem1,
            this.toolStripSeparator2,
            this.PersonasToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.CotizacionToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ArticulosToolStripMenuItem1
            // 
            this.ArticulosToolStripMenuItem1.Name = "ArticulosToolStripMenuItem1";
            this.ArticulosToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.ArticulosToolStripMenuItem1.Text = "Consultar Articulos";
            this.ArticulosToolStripMenuItem1.Click += new System.EventHandler(this.ArticulosToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // PersonasToolStripMenuItem1
            // 
            this.PersonasToolStripMenuItem1.Name = "PersonasToolStripMenuItem1";
            this.PersonasToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.PersonasToolStripMenuItem1.Text = "Consultar Personas";
            this.PersonasToolStripMenuItem1.Click += new System.EventHandler(this.PersonasToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
            // 
            // CotizacionToolStripMenuItem1
            // 
            this.CotizacionToolStripMenuItem1.Name = "CotizacionToolStripMenuItem1";
            this.CotizacionToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.CotizacionToolStripMenuItem1.Text = " Consultar Cotizacion";
            this.CotizacionToolStripMenuItem1.Click += new System.EventHandler(this.CotizacionToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(433, 338);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton ArticulostoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArticulosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem PersonasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton PersonastoolStripButton;
        private System.Windows.Forms.ToolStripButton CotizaciontoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem CotizacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}