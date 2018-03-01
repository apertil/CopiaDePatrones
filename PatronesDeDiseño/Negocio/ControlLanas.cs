using PatronesDeDiseño.Modelo;
using PatronesDeDiseño.ViewModel;
using PatronesDeDiseño.Vista.Lanas;
using System;
using System.Collections;
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
        public static List<Lanas> ListaficheroLanas;
      //  public static List<string> VistaModeloLanas = new List<string>();
        public static DataTable ficherolana;
        public static ArrayList intermedio = new ArrayList();



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

        /// <summary>
        /// Consulta Grosor de lana
        /// </summary>
        /// <param name="grosorLana"></param>
        /// <returns></returns>
        public static DataTable ConsultarGrosorLana(string grosorLana)
        {
            
            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    if (grosorLana == string.Empty)
                    {
                        var query_where = (from a in contexto.Lanas
                                          select a).Distinct().ToList();
                        ListaficheroLanas = query_where;
                        if (ListaficheroLanas.Count > 0)
                        { 
                            foreach (var item in ListaficheroLanas)
                            {

                                List<string> VistaLana = new List<string>();
                                string a = item.NombreLana.ToString();
                                VistaLana.Add(a);
                                intermedio.Add(VistaLana);
                                cSuccessful = true;
                                cResultException = "";

                            }
                        }
                    }
                    else
                    {
                             
                        var query_where1 = (from a in contexto.Lanas
                                           where a.NombreLana.Contains(grosorLana.Trim())
                                           select a).Distinct().ToList();
                        ListaficheroLanas = query_where1;
                        if (ListaficheroLanas.Count > 0)
                        {
                            foreach (var item in ListaficheroLanas)
                            {
                                List<string> VistaLana = new List<string>();
                                string a = item.NombreLana.ToString();
                                VistaLana.Add(a);
                                intermedio.Add(VistaLana);
                                cSuccessful = true;
                                cResultException = "";

                            }
                        }
                    }

                     if (intermedio.Count > 0)
                     {
                        ficherolana = LlenarResultado(intermedio);
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
            catch (Exception ex)
            {
                ficherolana = null;
                cResultException = ex.ToString();
                cSuccessful = false;
                
            }
            intermedio.Clear();
            ListaficheroLanas.Clear();
            ListaficheroLanas = null;
            return ficherolana;
        }
      
        /// <summary>
        /// Busqueda exacta del elemento para no modificar o borrar el elemento equivocado
        /// </summary>
        /// <param name="grosorLana"></param>
        public static DataTable BuscarExactoGrosorDelana(string grosorLana)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    var query_where1 = (from a in contexto.Lanas
                                       where a.NombreLana.ToLower() == grosorLana.Trim().ToLower()
                                       select a).Distinct().ToList();

                    ListaficheroLanas = query_where1;
                    if (ListaficheroLanas.Count > 0)
                    {
                        foreach (var item in ListaficheroLanas)
                        {
                            if (item.NombreLana != null && item.NombreLana.ToLower() == grosorLana.Trim().ToLower())
                            {
                                List<string> VistaLana = new List<string>();
                                LanasViewModel.IndiceBuscaLanas = item.IdLana;
                                string a = item.NombreLana.ToString();
                                VistaLana.Add(a);
                                intermedio.Add(VistaLana);
                                cSuccessful = true;
                                cResultException = "";
                            }
                        }
                    }


                    if (intermedio.Count > 0)
                    {
                        ficherolana = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = "No se ha encontrado la revista";
                        cSuccessful = false;
                    }
                }

            }
            catch (Exception ex)
            {
                ficherolana = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            ListaficheroLanas.Clear();
            ListaficheroLanas = null;
            return ficherolana;
           
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
                using (PatronesEntities contexto = new PatronesEntities())
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
                using (PatronesEntities contexto = new PatronesEntities())
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

        /// <summary>
        /// Rellena el datatable para los data gried
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
       private static DataTable LlenarResultado(ArrayList Datos)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Lana");

            foreach (List<string> item in Datos)
            {
                DataRow row = dt.NewRow();
                row["Nombre Lana"] = item[0];
                dt.Rows.Add(row);
               
            }
            return dt;

        }

        #endregion
   }
}
