using PatronesDeDiseño.Modelo;
using PatronesDeDiseño.ViewModel;
using PatronesDeDiseño.Vista.Lanas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
   public class ControlLanas
    {
        #region "1.- Variables privadas de la clase"
        /// <summary>
        /// Mensaje de la Excepción Generada
        /// </summary>

        internal static string cResultException;

        /// <summary>
        /// Indica el Resultado de la Operación Actual
        /// </summary>
        internal static bool cSuccessful;

        #endregion

        #region "2.- Variables publicas de la clase"
        /// <summary>
        /// Propiedad con el Mensaje del Error o de la Excepción Generada
        /// </summary>
        /// <returns>El Mensaje del Error o de la Excepción Generada</returns>
        public static string ResultException
        {

            get { return cResultException; }
        }
        /// <summary>
        /// Propiedad que Indica si el Proceso ha Finalizado Correctamente
        /// </summary>
        /// <returns>True si el Proceso ha Finalizado Correctamente - False en caso Contrario</returns>
        public static bool Result
        {

            get { return cSuccessful; }
        }
        public static List<Lanas> fichero;
        public static List<string> VistaModeloLanas = new List<string>();
        public static DataTable ficherolana;



        #endregion

        #region "3.- Metodos Publicos de la clase

        /// <summary>
        /// Inserta nuevo tipo de lana
        /// </summary>
        /// <param name="grosorLana"></param>
        public static void InsertarGrosorDelana(string grosorLana)
        {
            try
            {
                Lanas lanas = new Lanas();
                lanas.NombreLana = grosorLana;
                PatronEntit.Instancia.Lanas.Add(lanas);
                PatronEntit.Instancia.SaveChanges();
                cResultException = null;
                cSuccessful = true;
            }
            catch (Exception ex)
            {

                cResultException = ex.ToString();
                cSuccessful = false;
            }
           

        }

        public static DataTable ConsultarGrosorLana(string grosorLana)
        {
            
            try
            {
                using (contexto contexto = new contexto())
                {
                    if (grosorLana == string.Empty)
                    {
                        var query_where = (from a in contexto.Lanas
                                          select a).Distinct().ToList();
                        fichero = query_where;

                        foreach (var item in fichero)
                        {
                            string a = item.NombreLana.ToString();
                            VistaModeloLanas.Add(a);

                        }
                    }
                    else
                    {
                             
                        var query_where1 = (from a in contexto.Lanas
                                           where a.NombreLana.Contains(grosorLana.Trim())
                                           select a).Distinct().ToList();
                        fichero = query_where1;
                        foreach (var item in fichero)
                        {
                            string a = item.NombreLana.ToString();
                            VistaModeloLanas.Add(a);

                        }

                    }
                   
                     ficherolana = LlenarResultado(VistaModeloLanas);
                     cResultException = null;
                     cSuccessful = true;
                }
               
            }
            catch (Exception ex)
            {
                ficherolana = null;
                cResultException = ex.ToString();
                cSuccessful = false;
                
            }

            return ficherolana;
        }
        /// <summary>
        /// Busca nuevo tipo de lana
        /// </summary>
        /// <param name="grosorLana"></param>
        public static void BuscarGrosorDelana(string grosorLana)
        {
            try
            {
                using (contexto contexto = new contexto())
                { 
                  var query_where1 = from a in contexto.Lanas
                                       where a.NombreLana.Contains(grosorLana.Trim())
                                       select a;
                    
                    foreach (var a in query_where1)
                    {
                        if (a.NombreLana != null && a.NombreLana.Contains(grosorLana.Trim()))
                        {
                            LanasViewModel.IndiceBuscaLanas = a.IdLana;
                            cResultException = null;
                            cSuccessful = true;
                        }
                        else
                        {
                            cResultException = "No se ha encontrado el elemento";
                            cSuccessful = false;
                        }

                    }


                }
            }
            catch (Exception ex)
            {
                cResultException = ex.ToString();
                cSuccessful = false;
            }
        }
        /// <summary>
        /// Busqueda exacta del elemento para no modificar o borrar el elemento equivocado
        /// </summary>
        /// <param name="grosorLana"></param>
        public static void BuscarExactoGrosorDelana(string grosorLana)
        {
            try
            {
                using (contexto contexto = new contexto())
                {
                    var query_where1 = from a in contexto.Lanas
                                       where a.NombreLana == grosorLana.Trim()
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombreLana != null && a.NombreLana == grosorLana.Trim())
                        {
                            LanasViewModel.IndiceBuscaLanas = a.IdLana;
                            cResultException = null;
                            cSuccessful = true;
                        }
                        else
                        {
                            cResultException = "No se ha encontrado el elemento";
                            cSuccessful = false;
                        }

                    }


                }
            }
            catch (Exception ex)
            {
                cResultException = ex.ToString();
                cSuccessful = false;
            }
        }








        /// <summary>
        /// Modifica el tipo de lana
        /// </summary>
        /// <param name="idregistro"></param>
        /// <param name="grosorModificado"></param>
        public static void ModificarGrosorDelana(int idregistro, string grosorModificado)
        {
            try
            {
                var cliente = new Lanas { IdLana = idregistro };
                using (contexto contexto = new contexto())
                {
                    contexto.Lanas.Attach(cliente);
                    cliente.NombreLana = grosorModificado;
                    contexto.Configuration.ValidateOnSaveEnabled = false;
                    contexto.SaveChanges();
                    cResultException = null;
                    cSuccessful = true;
                }
     
            }
            catch (Exception ex)
            {

                cResultException = ex.ToString();
                cSuccessful = false;
            }
        }

        /// <summary>
        /// Elimina el tipo de lana
        /// </summary>
        /// <param name="idregistro"></param>
        public static void EliminarLana(int idregistro)
        {
            try
            {
                var cliente = new Lanas { IdLana = idregistro };
                using (contexto contexto = new contexto())
                {
                    contexto.Lanas.Attach(cliente);
                    contexto.Lanas.Remove(cliente);
                    contexto.SaveChanges();
                    cResultException = null;
                    cSuccessful = true;
                }
            }
            catch (Exception ex)
            {

                cResultException = ex.ToString();
                cSuccessful = false;
            }

        }
       private static DataTable LlenarResultado(List<string> list)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Lana");

            foreach (string item in list)
            {
                dt.Rows.Add(item);
            }
            return dt;

        }

        #endregion
   }
}
