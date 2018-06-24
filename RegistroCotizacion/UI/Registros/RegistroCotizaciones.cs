using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroCotizacion.BLL;
using RegistroCotizacion.DAL;
using RegistroCotizacion.Entidades;

namespace RegistroCotizacion.UI.Registros
{
    public partial class RegistroCotizaciones : Form
    {
        public RegistroCotizaciones()
        {
            InitializeComponent();
            LlenarComboBox();
        }

            private void Buscarbutton_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Cotizacion cotizacion = BLL.CotizaBLL.Buscar(id);

                if (cotizacion != null)
                {
                    LlenarCampos(cotizacion);
                }
                else
                    MessageBox.Show("No se encontro!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            private void Nuevobutton_Click(object sender, EventArgs e)
            {
                IdnumericUpDown.Value = 0;
                fechaDateTimePicker.Value = DateTime.Now;
                ObservacionestextBox.Clear();
                CantidadtextBox.Clear();
                PreciotextBox.Clear();
                ImportetextBox.Clear();
                TotalnumericUpDown.Value = 0;

                DetalledataGridView.DataSource = null;
                errorProvider.Clear();
            }

            private void Guardarbutton_Click(object sender, EventArgs e)
            {
                Cotizacion cotizacion;
                bool Paso = false;

                if (HayErrores())
                {
                    MessageBox.Show("Favor revisar todos los campos", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cotizacion = LlenaClase();

                //Determinar si es Guardar o Modificar
                if (IdnumericUpDown.Value == 0)
                    Paso = BLL.CotizaBLL.Guardar(cotizacion);
                else
                    //todo: validar que exista.
                    Paso = BLL.CotizaBLL.Modificar(cotizacion);

                //Informar el resultado
                if (Paso)
                {
                    Nuevobutton.PerformClick();
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            private void Eliminarbutton_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                //todo: validar que exista
                if (BLL.CotizaBLL.Eliminar(id))
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            private void Agregarbutton_Click(object sender, EventArgs e)
            {
                List<CotizaDetalle> detalle = new List<CotizaDetalle>();

                if (DetalledataGridView.DataSource != null)
                {
                    detalle = (List<CotizaDetalle>)DetalledataGridView.DataSource;
                }

                //Agregar un nuevo detalle con los datos introducidos.
                detalle.Add(
                    new CotizaDetalle(
                        id: 0,
                        cotizacionId: (int)IdnumericUpDown.Value,
                        personaId: (int)PersonacomboBox.SelectedValue,
                        articuloId: (int)ArticulocomboBox.SelectedValue,
                        cantidad: (int)Convert.ToInt32(CantidadtextBox.Text),
                        precio: (int)Convert.ToInt32(PreciotextBox.Text),
                        importe: (int)Convert.ToInt32(ImportetextBox.Text)

                    ));

                //Cargar el detalle al Grid
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = detalle;
            }
            private void LlenarComboBox()
            {
                Repositorio<Personas> repositorio = new Repositorio<Personas>(new Contexto());
                PersonacomboBox.DataSource = repositorio.GetList(c => true);
                PersonacomboBox.ValueMember = "PersonaId";
                PersonacomboBox.DisplayMember = "Nombres";

                Repositorio<Articulos> repositori0 = new Repositorio<Articulos>(new Contexto());
                ArticulocomboBox.DataSource = repositori0.GetList(c => true);
                ArticulocomboBox.ValueMember = "ArticuloId";
                ArticulocomboBox.DisplayMember = "Descripcion";
            }

            private Cotizacion LlenaClase()
            {
                Cotizacion cotizacion = new Cotizacion();

                cotizacion.CotizacionId = Convert.ToInt32(IdnumericUpDown.Value);
                cotizacion.Fecha = fechaDateTimePicker.Value;
                cotizacion.Comentario = ObservacionestextBox.Text;

                //Agregar cada linea del Grid al detalle
                foreach (DataGridViewRow item in DetalledataGridView.Rows)
                {
                    cotizacion.AgregarDetalle(
                        ToInt(item.Cells["id"].Value),
                        ToInt(item.Cells["CotizacionId"].Value),
                        ToInt(item.Cells["PersonaId"].Value),
                        ToInt(item.Cells["ArticuloId"].Value),
                        ToInt(item.Cells["Cantidad"].Value),
                        ToInt(item.Cells["Precio"].Value),
                        ToInt(item.Cells["Importe"].Value)
                      );
                }
                return cotizacion;
            }
            private bool HayErrores()
            {
                bool HayErrores = false;

                if (String.IsNullOrWhiteSpace(ObservacionestextBox.Text))
                {
                    errorProvider.SetError(ObservacionestextBox,
                        "No debes dejar el Comentario vacio");
                    HayErrores = true;
                }

                if (String.IsNullOrWhiteSpace(CantidadtextBox.Text))
                {
                    errorProvider.SetError(ObservacionestextBox,
                        "No debes dejar cantidad vacio");
                    HayErrores = true;
                }

                if (String.IsNullOrWhiteSpace(PreciotextBox.Text))
                {
                    errorProvider.SetError(PreciotextBox,
                        "No debes dejar precio vacio");
                    HayErrores = true;
                }

                if (String.IsNullOrWhiteSpace(ImportetextBox.Text))
                {
                    errorProvider.SetError(ImportetextBox,
                        "No debes dejar el importe vacio");
                    HayErrores = true;
                }

                if (DetalledataGridView.RowCount == 0)
                {
                    errorProvider.SetError(DetalledataGridView,
                        "Es obligatorio seleccionar la Cotizacion");
                    HayErrores = true;
                }

                return HayErrores;
            }

            private int ToInt(object valor)
            {
                int retorno = 0;

                int.TryParse(valor.ToString(), out retorno);

                return retorno;
            }

            private void LlenarCampos(Cotizacion cotizacion)
            {
                IdnumericUpDown.Value = cotizacion.CotizacionId;
                fechaDateTimePicker.Value = cotizacion.Fecha;
                ObservacionestextBox.Text = cotizacion.Comentario;

                //Cargar el detalle al Grid
                DetalledataGridView.DataSource = cotizacion.Detalle;

                //Ocultar columnas
                DetalledataGridView.Columns["Id"].Visible = false;
                DetalledataGridView.Columns["CotizacionId"].Visible = false;
            }
        
            private void PreciotextBox_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    if (Convert.ToInt32(PreciotextBox.Text) != 0)
                    {
                        TotalnumericUpDown.Value += Convert.ToInt32(PreciotextBox.Text);
                    }
                }
                catch (Exception)
                {
                    throw;

                }
            }
        
    }
}
