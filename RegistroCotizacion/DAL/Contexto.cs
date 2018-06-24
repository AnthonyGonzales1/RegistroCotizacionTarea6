using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroCotizacion.BLL;
using RegistroCotizacion.Entidades;
using System.Data.Entity;


namespace RegistroCotizacion.DAL
{
    // Aqui agregamos public tambien, para que la clase pueda ser encontrada en cualquier parte del proyecto, 
    //y heredamos de  DbContext para que EntityFramework pueda hacer su magia
    public class Contexto : System.Data.Entity.DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }
        // base("ConStr") para pasar la conexion a la clase base de EntityFramework 
        public Contexto() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
