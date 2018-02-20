using PatronesDeDiseño.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
   public static class ControlTipDeTejer
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
        public static List<TiposDeTejer> fichero;
        public static List<string> VistaTipoDeTejer = new List<string>();
        public static DataTable ficheroTipoDeTjer;
        #endregion

        #region "3.- Metodos Publicos de la clase

        /// <summary>
        /// Insertar Tipos de tejido
        /// </summary>
        /// <param name="tipodetejer"></param>
        public static void InsertarTiposDeTejer(string tipodetejer)
        {
            try
            {
                TiposDeTejer tipdetej = new TiposDeTejer();
                tipdetej.NombreDeTejer = tipodetejer;
                PatronEntit.Instancia.TiposDeTejer.Add(tipdetej);
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
        /// Modificar Tipos de Tejido
        /// </summary>
        /// <param name="tipodetejer"></param>
        public static void ModificarTiposDeTejer(int idTipodetejer, string tipodetejer)
        {
            var cliente = new TiposDeTejer { IdTiposTejer = idTipodetejer };
            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.TiposDeTejer.Attach(cliente);
                    cliente.NombreDeTejer = tipodetejer;
                    contexto.Configuration.ValidateOnSaveEnabled = false;
                    contexto.SaveChanges();
                    cResultException = null;
                    cSuccessful = true;
                }
            }
            catch (Exception ex )
            {
                cResultException = ex.ToString();
                cSuccessful = false;
            }

        }
        /// <summary>
        /// Consulta Los tipos de tejido
        /// </summary>
        /// <param name="TipoDetejer"></param>
        /// <returns></returns>
        public static DataTable ConsultarTipoDetejer(string TipoDetejer)
        {
            try
            {

                using (PatronesEntities contexto = new PatronesEntities())
                {
                    if (TipoDetejer == string.Empty)
                    {
                        var query_where = (from a in contexto.TiposDeTejer
                                           select a).Distinct().ToList();
                        fichero = query_where;
                        if (fichero.Count > 0)
                        { 
                            foreach (var item in fichero)
                            {
                                string a = item.NombreDeTejer.ToString();
                                VistaTipoDeTejer.Add(a);

                            }
                        }
                    }
                    else
                    {

                        var query_where1 = (from a in contexto.TiposDeTejer
                                            where a.NombreDeTejer.Contains(TipoDetejer.Trim())
                                            select a).Distinct().ToList();
                        fichero = query_where1;
                        if (fichero.Count > 0)
                        { 
                            foreach (var item in fichero)
                            {
                                string a = item.NombreDeTejer.ToString();
                                VistaTipoDeTejer.Add(a);

                            }

                        }
                    }

                    if (VistaTipoDeTejer.Count > 0)
                    {
                        ficheroTipoDeTjer = LlenarResultado(VistaTipoDeTejer);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = " No se ha encontrado el elemento pedido";
                        cSuccessful = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ficheroTipoDeTjer = null;
                cResultException = ex.ToString();
                cSuccessful = false;
            }

            VistaTipoDeTejer.Clear();
            fichero.Clear();
            return ficheroTipoDeTjer;
        }

        /// <summary>
        /// Buscar Tipos de Tejidos para Modificar y Borrar
        /// </summary>
        /// <param name="tipoDetejer"></param>
        public static void BuscarTipoDetejer(string tipoDetejer)
        {
            try
            {

                using (PatronesEntities contexto = new PatronesEntities())
                {
                    var query_where1 = from a in contexto.TiposDeTejer
                                       where a.NombreDeTejer.Contains(tipoDetejer.Trim())
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombreDeTejer != null && a.NombreDeTejer.Contains(tipoDetejer.Trim()))
                        {
                            TipDeTejerViewModel.IdTipoDeTejer = a.IdTiposTejer;
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



        public static void BuscarExactoTipoDetejer(string tipoDetejer)
        {
            try
            {

                using (PatronesEntities contexto = new PatronesEntities())
                {
                    var query_where1 = from a in contexto.TiposDeTejer
                                       where a.NombreDeTejer.Contains(tipoDetejer.Trim())
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombreDeTejer != null && a.NombreDeTejer == tipoDetejer)
                        {
                            TipDeTejerViewModel.IdTipoDeTejer = a.IdTiposTejer;
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
        /// Eliminar Tipos de Tejido
        /// </summary>
        /// <param name="idregistro"></param>
        public static void EliminarTipoDetejer(int idregistro)
        {
            try
            {
                var cliente = new TiposDeTejer { IdTiposTejer = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.TiposDeTejer.Attach(cliente);
                    contexto.TiposDeTejer.Remove(cliente);
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


        #endregion


        #region "4.-Métodos privados de la clase"

        /// <summary>
        /// Rellena el datatable para rellenar el Datagried
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static DataTable LlenarResultado(List<string> list)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Tipo de Tejido");

            foreach (string item in list)
            {
                dt.Rows.Add(item);
            }
            return dt;

        }

        #endregion

    }
}
