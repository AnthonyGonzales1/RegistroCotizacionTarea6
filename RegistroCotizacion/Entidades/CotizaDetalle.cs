using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroCotizacion.Entidades
{
    public class CotizaDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ArticuloId { get; set; }
        public int CotizacionId { get; set; }
        public int PersonaId { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public Decimal Importe { get; set; }

        [ForeignKey("ArticuloId")]
        //Permite indicar por cual campo se usara
        //la NAVIGATION PROPERTY
        public virtual Articulos Articulos { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Personas { get; set; }


        public CotizaDetalle()
        {
            this.Id = 0;
            this.CotizacionId = 0;
        }

        /// <summary>
        /// Este constructor es opcional solo lo agrego por comodidad
        /// </summary>
        public CotizaDetalle(int id, int articuloId, int cotizacionId, int personaId, int cantidad, Decimal precio, Decimal importe)
        {
            this.Id = id;
            this.ArticuloId = articuloId;
            this.CotizacionId = cotizacionId;
            this.PersonaId = personaId;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe = importe;
        }
    }
}
