﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace RegistroCotizacion.Entidades
{
    //Debe ser PUBLIC para que sea visible para las demas capas
    public class Personas
    {
        //Esta es la llave primaria
        [Key]
        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        //todo: aprender a crear las propiedades de la forma corta.
        public Personas()
        {
            /*PersonaId = 0;
            Fecha = DateTime.Now;//inicializamos con la fecha actual.
            Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;*/

        }

        public override string ToString()
        {
            return this.Nombres;
        }

    }
}