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
    public class CotizaBLL
    {
            /// <summary>
            /// Permite guardar una entidad en la base de datos
            /// </summary>
            /// <param name="cotizaciones">Una instancia de cotizaciones</param>
            /// <returns>Retorna True si guardo o Falso si falló </returns>
            public static bool Guardar(Cotizacion cotizaciones)
            {
                bool paso = false;

                Contexto contexto = new Contexto();
                try
                {
                    if (contexto.Cotizacion.Add(cotizaciones) != null)
                    {
                        contexto.SaveChanges(); //Guardar los cambios
                        paso = true;
                    }
                    //siempre hay que cerrar la conexion
                    contexto.Dispose();
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
            /// <param name="visita">Una instancia de Cotizacion</param>
            /// <returns>Retorna True si Modifico o Falso si falló </returns>
            public static bool Modificar(Cotizacion cotizacion)
            {
                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {
                    //todo: buscar las entidades que no estan para removerlas

                    //recorrer el detalle
                    foreach (var item in cotizacion.Detalle)
                    {
                        //Muy importante indicar que pasara con la entidad del detalle
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }

                    //Indicar que se esta modificando el encabezado
                    contexto.Entry(cotizacion).State = EntityState.Modified;

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
            ///<param name="id">El Id de la Cotizacion que se desea eliminar </param>
            /// <returns>Retorna True si Eliminó o Falso si falló </returns>
            public static bool Eliminar(int id)
            {
                bool paso = false;

                Contexto contexto = new Contexto();
                try
                {
                    Cotizacion cotizacion = contexto.Cotizacion.Find(id);

                    contexto.Cotizacion.Remove(cotizacion);

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
            ///<param name="id">El Id de la Cotizacion que se desea encontrar </param>
            /// <returns>Retorna la visita encontrada </returns>
            public static Cotizacion Buscar(int id)
            {
                Contexto contexto = new Contexto();
                Cotizacion cotizacion = new Cotizacion();
                try
                {
                    cotizacion = contexto.Cotizacion.Find(id);
                    //Cargar la lista en este punto porque
                    //luego de hacer Dispose() el Contexto 
                    //no sera posible leer la lista
                    cotizacion.Detalle.Count();

                    //Cargar los nombres de las ciudades
                    foreach (var item in cotizacion.Detalle)
                    {
                    //forzando la ciudad a cargarse
                    string a = item.Articulos.Descripcion;
                    string p = item.Personas.Nombres;
                }

                    contexto.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }
                return cotizacion;
            }

            /// <summary>
            /// Permite extraer una lista de Visitas de la base de datos
            /// </summary> 
            ///<param name="expression">Expression Lambda conteniendo los filtros de busqueda </param>
            /// <returns>Retorna una lista de Visitas</returns>
            public static List<Cotizacion> GetList(Expression<Func<Cotizacion, bool>> expression)
            {
                List<Cotizacion> cotizacion = new List<Cotizacion>();
                Contexto contexto = new Contexto();
                try
                {
                    cotizacion = contexto.Cotizacion.Where(expression).ToList();
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return cotizacion;
            }
        }
    }
