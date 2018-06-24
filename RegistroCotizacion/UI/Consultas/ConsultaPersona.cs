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

namespace RegistroCotizacion.UI.Consultas
{
    public partial class ConsultaPersona : Form
    {
        public ConsultaPersona()
        {
            InitializeComponent();
        }

        private void BuscarConsultabutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Personas, bool>> filtro = x => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriteriocomboBox.Text);
                    filtro = x => x.PersonaId == id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 1:// nombre
                    filtro = x => x.Nombres.Contains(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2:// cedula
                    filtro = x => x.Cedula.Equals(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3:// direccion
                    filtro = x => x.Direccion.Contains(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 4://telefono
                    filtro = x => x.Telefono.Equals(CriteriocomboBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
            }
            ConsultadataGridView.DataSource = BLL.PersonasBLL.GetList(filtro);
        }
    }
}
