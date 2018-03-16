using PatronesDeDiseño.ViewModel;
using System;
using System.Collections;
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
        public static List<TiposDeTejer> ListarficheroTejido;
        public static DataTable ficheroTipoDeTjer;
        public static ArrayList intermedio = new ArrayList();
        private static PatronesEntities contexto = new PatronesEntities();
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
                    contexto.TiposDeTejer.Attach(cliente);
                    cliente.NombreDeTejer = tipodetejer;
                    contexto.Configuration.ValidateOnSaveEnabled = false;
                    contexto.SaveChanges();
                    cResultException = null;
                    cSuccessful = true;
                
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

                    if (TipoDetejer == string.Empty)
                    {

                        ListarficheroTejido = contexto.TiposDeTejer.ToList();
                       
                            foreach (var item in ListarficheroTejido)
                            {
                                List<string> VistaTipoDeTejer = new List<string>();
                                string a = item.NombreDeTejer.ToString();
                                VistaTipoDeTejer.Add(a);
                                intermedio.Add(VistaTipoDeTejer);
                                cSuccessful = true;
                                cResultException = "";
                             
                            }
                        
                    }
                    else
                    {

                        ListarficheroTejido = contexto.TiposDeTejer.ToList();
                   
                            foreach (var item in ListarficheroTejido)
                            {
                                List<string> VistaTipoDeTejer = new List<string>();
                                string a = item.NombreDeTejer.ToString();
                                VistaTipoDeTejer.Add(a);
                                intermedio.Add(VistaTipoDeTejer);
                                cSuccessful = true;
                                cResultException = "";

                            }
                        
                    }

                    if (intermedio.Count > 0)
                    {
                        ficheroTipoDeTjer = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = " No se ha encontrado el elemento pedido";
                        cSuccessful = false;
                    }
                
            }
            catch (Exception ex)
            {
                ficheroTipoDeTjer = null;
                cResultException = ex.ToString();
                cSuccessful = false;
            }
            intermedio.Clear();
            ListarficheroTejido.Clear();
            ListarficheroTejido = null;
            return ficheroTipoDeTjer;
        }

        
        public static DataTable BuscarExactoTipoDetejer(string tipoDetejer)
        {
            try
            {
                
                    ListarficheroTejido = contexto.TiposDeTejer.ToList();
                    
                        foreach (var item in ListarficheroTejido)
                        {
                            if (item.NombreDeTejer != null && item.NombreDeTejer.ToLower() == tipoDetejer.Trim().ToLower())
                            {
                                List<string> VistaTipoDeTejer = new List<string>();
                                string a = item.NombreDeTejer.ToString();
                                VistaTipoDeTejer.Add(a);
                                intermedio.Add(VistaTipoDeTejer);
                                cSuccessful = true;
                                cResultException = "";
                            }
                        }
              
                    if (intermedio.Count > 0)
                    {
                        ficheroTipoDeTjer = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = " No se ha encontrado el elemento pedido";
                        cSuccessful = false;
                    }

                
            }
            catch (Exception ex)
            {
                ficheroTipoDeTjer = null;
                cResultException = ex.ToString();
                cSuccessful = false;
            }
            intermedio.Clear();
            ListarficheroTejido.Clear();
            ListarficheroTejido = null;
            return ficheroTipoDeTjer;

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
                
                    contexto.TiposDeTejer.Attach(cliente);
                    contexto.TiposDeTejer.Remove(cliente);
                    contexto.SaveChanges();
                    cResultException = null;
                    cSuccessful = true;
                
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
        private static DataTable LlenarResultado(ArrayList Datos)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Tipo de Tejido");


            foreach (List<string> item in Datos)
            {
                DataRow row = dt.NewRow();
                row["Nombre Tipo de Tejido"] = item[0];
                dt.Rows.Add(row);

            }
            return dt;

        }

        #endregion

    }
}
