using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq.Expressions;
using RegistroCotizacion.BLL;
using RegistroCotizacion.DAL;
using RegistroCotizacion.Entidades;

namespace RegistroCotizacion.UI.Registros
{
    public partial class RegistroArticulo : Form
    {
        public RegistroArticulo()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Articulos articulo = BLL.ArticulosBLL.Buscar(id);

            if (articulo != null)
            {

                DescripciontextBox.Text = articulo.Descripcion;
                PrecionumericUpDown.Value = articulo.Precio;
                VencimientodateTimePicker.Text = articulo.Fecha.ToString();
                CantidadttextBox.Text = articulo.Cantidad.ToString();

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider.Clear();

            //Determinar si es Guardar o Modificar
            if (IdnumericUpDown.Value == 0)
                paso = BLL.ArticulosBLL.Guardar(LlenarClase());
            else
                paso = BLL.ArticulosBLL.Modificar(LlenarClase());

            //Informar el resultado
            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            PrecionumericUpDown.Value = 0;
            CantidadttextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private Articulos LlenarClase()
        {

            Articulos articulo = new Articulos();

            articulo.ArticuloId = Convert.ToInt32(IdnumericUpDown.Value);
            articulo.Descripcion = DescripciontextBox.Text;
            articulo.Precio = Convert.ToInt32(PrecionumericUpDown.Value);
            articulo.Fecha = VencimientodateTimePicker.Value;
            articulo.Cantidad = Convert.ToInt32(CantidadttextBox.Text);

            return articulo;
        }
        private bool Validar(int validar)
        {bool HayErrores = false;
            //todo: quitar los mensajes de los errores que ya no estan.

            //todo: Validar que el nombre no se duplique
            if (validar == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IdnumericUpDown,
                    "No debes dejar el ID vacio");
                HayErrores = true;

            }
            if (validar == 2 && DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox,
                    "No debes dejar la descripcion vacia");
                HayErrores = true;
            }
            if (validar == 2 && PrecionumericUpDown.Value == 0)
            {errorProvider.SetError(PrecionumericUpDown,
                    "No debes dejar el precio vacio");
                HayErrores = true;
            }
            if (validar == 2 && CantidadttextBox.Text == string.Empty)
            {

                errorProvider.SetError(CantidadttextBox,
                    "No debes dejar la cantidad cotizada");
            }
            //todo: validar demas campos
            return HayErrores;
        }
    }
}
