using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Threading.Tasks;
using RegistroCotizacion.DAL;
using RegistroCotizacion.Entidades;

namespace RegistroCotizacion.BLL
{
    /// <summary>
    /// En esta clase debemos programar toda la logica de negocios
    /// </summary>
    public class ArticulosBLL
    {
        /// <summary>
        /// Permite guardar una entidad en la base de datos
        /// </summary>
        /// <param name="articulos">Una instancia de Articulos</param>
        /// <returns>Retorna True si guardo o Falso si falló </returns>
        public static bool Guardar(Articulos articulo)
            {
                bool paso = false;
                //Creamos una instancia del contexto para poder conectar con la BD
                Contexto contexto = new Contexto();
                try
                {
                    if (contexto.Articulos.Add(articulo) != null)
                    {
                        contexto.SaveChanges();//Guardar los cambios
                        paso = true;
                    }
                    contexto.Dispose();//siempre hay que cerrar la conexion
            }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }
        /// <summary>
        /// Permite Modificar una entidad en la base de datos 
        /// </summary>
        /// <param name="articulos">Una instancia de Articulos</param>
        /// <returns>Retorna True si Modifico o Falso si falló </returns>
        public static bool Modificar(Articulos articulos)
            {
                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {
                    contexto.Entry(articulos).State = EntityState.Modified;
                    if (contexto.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                contexto.Dispose();
            }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }

        /// <summary>
        /// Permite Eliminar una entidad en la base de datos
        /// </summary>
        ///<param name="id">El Id de la persona que se desea eliminar </param>
        /// <returns>Retorna True si Eliminó o Falso si falló </returns>
        public static bool Eliminar(int id)
            {
                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {
                    Articulos articulos = contexto.Articulos.Find(id);

                    contexto.Articulos.Remove(articulos);

                    if (contexto.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }

        /// <summary>
        /// Permite Buscar una entidad en la base de datos
        /// </summary>
        ///<param name="id">El Id de la persona que se desea encontrar </param>
        /// <returns>Retorna la persona encontrada </returns>
        public static Articulos Buscar(int id)
            {
                Contexto contexto = new Contexto();
                Articulos articulos = new Articulos();
                 try
                 {
                     articulos = contexto.Articulos.Find(id);
                     contexto.Dispose();
                 }
                 catch (Exception)
                 {
                    throw;
                 }
                 return articulos;
            }
        /// <summary>
        /// Permite extraer una lista de Personas de la base de datos
        /// </summary> 
        ///<param name="expression">Expression Lambda conteniendo los filtros de busqueda </param>
        /// <returns>Retorna una lista de personas</returns>
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
            {
                List<Articulos> articulos = new List<Articulos>();
                Contexto contexto = new Contexto();
                try
                {
                    articulos = contexto.Articulos.Where(expression).ToList();
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return articulos;
            }
       
    }
}
