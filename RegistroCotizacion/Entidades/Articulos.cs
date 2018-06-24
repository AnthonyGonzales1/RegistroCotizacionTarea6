using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistroCotizacion.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public Articulos(int articulosId, string descripcion, Decimal precio, DateTime fecha, int cantidad)
        {
            ArticuloId = articulosId;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            Fecha = fecha;
        }

        public Articulos()
        {
            this.ArticuloId = 0;
            this.Descripcion = string.Empty;
            this.Precio = 0;
            this.Cantidad = 0;
            this.Fecha = DateTime.Now;
            
        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
