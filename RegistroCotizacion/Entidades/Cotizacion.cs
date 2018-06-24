using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCotizacion.Entidades
{
    public class Cotizacion
    {
        [Key]
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }
        [StringLength(100)]
        public string Comentario { get; set; }
        public Decimal Monto { get; set; }
        public virtual List<CotizaDetalle> Detalle { get; set; }

        public Cotizacion()
        {
            //Es obligatorio inicializar la lista
            this.Detalle = new List<CotizaDetalle>();
        }

        /*public Cotizacion(int id, DateTime fecha, string comentario, Decimal monto, List<CotizaDetalle> detalle)
        {
            CotizacionId = id;
            Fecha = fecha;
            Comentario = comentario;
            Monto = monto;
            Detalle = detalle;
        }*/

        /// <summary>
        /// Este metodo permite agretar un item a la lista
        /// No es obligatorio, lo creo por comodidad
        /// </summary>
        public void AgregarDetalle(int id, int CotizacionId, int PersonaId, int ArticuloId, int Cantidad, int Precio, int Importe)
        {
            this.Detalle.Add(new CotizaDetalle(id, CotizacionId, PersonaId, ArticuloId, Cantidad, Precio, Importe));
        }
    }
}
