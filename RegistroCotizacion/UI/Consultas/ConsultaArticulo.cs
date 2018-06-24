using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RegistroCotizacion.Entidades;
using RegistroCotizacion.BLL;

namespace RegistroCotizacion.UI.Consultas
{
    public partial class ConsultaArticulo : Form
    {
        public ConsultaArticulo()
        {
            InitializeComponent();
        }

        private void BuscarConsultabutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Articulos, bool>> filtro = x => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://ID articulo
                    id = Convert.ToInt32(CriteriocomboBox.Text);
                    filtro = x => x.ArticuloId == id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 1://Descripcion articulo
                    filtro = x => x.Descripcion.Contains(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2://Precio articulo
                    filtro = x => x.Precio.Equals(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3://Cantidad cotizada
                    filtro = x => x.Cantidad.Equals(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                /*case 4:
                    filtro = x => x.Fecha.Equals(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;*/
            }


            ConsultadataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
