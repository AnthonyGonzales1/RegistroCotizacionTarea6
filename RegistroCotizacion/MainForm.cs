using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using RegistroCotizacion.UI.Registros;
using RegistroCotizacion.UI.Consultas;


namespace RegistroCotizacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Registros.RegistroArticulo registro = new UI.Registros.RegistroArticulo();
            //registro.MdiParent = this;
            registro.Show();
            
        }

        private void PersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Registros.RegistroPersona registro = new UI.Registros.RegistroPersona();
            //registro.MdiParent = this;
            registro.Show();
        }

        private void CotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Registros.RegistroCotizaciones registro = new UI.Registros.RegistroCotizaciones();
            //registro.MdiParent = this;
            registro.Show();
        }

        private void ArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Consultas.ConsultaArticulo consulta = new UI.Consultas.ConsultaArticulo();
            //consulta.MdiParent = this;
            consulta.Show();
        }

        private void PersonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Consultas.ConsultaPersona consulta = new UI.Consultas.ConsultaPersona();
            //consulta.MdiParent = this;
            consulta.Show();
        }

        private void CotizacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ArticulostoolStripButton_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Registros.RegistroArticulo registro = new UI.Registros.RegistroArticulo();
            //registro.MdiParent = this;
            registro.Show();
        }

        private void PersonastoolStripButton_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Registros.RegistroPersona registro = new UI.Registros.RegistroPersona();
            //registro.MdiParent = this;
            registro.Show();
        }

        private void CotizaciontoolStripButton_Click(object sender, EventArgs e)
        {
            RegistroCotizacion.UI.Registros.RegistroCotizaciones registro = new UI.Registros.RegistroCotizaciones();
            //registro.MdiParent = this;
            registro.Show();
        }
    }
}

