using PatronesDeDiseño.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
   public class ControlTipoDeprendas
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
        public static List<Prendas> fichero;
        public static List<string> VistaModeloPrendas = new List<string>();
        public static DataTable ficheroPrenda;



        #endregion

        #region "3.- Metodos Publicos de la clase

       /// <summary>
       /// Nueva prenda en base de datos
       /// </summary>
       /// <param name="NuevaPrenda"></param>
        public static void InsertarPrenda(string NuevaPrenda)
        {
            try
            {
                Prendas TPrenda = new Prendas();
                TPrenda.NombrePrendas = NuevaPrenda;
                PatronEntit.Instancia.Prendas.Add(TPrenda);
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
        /// Consulta de los tipos de prenda
        /// </summary>
        /// <param name="ConsPrenda"></param>
        /// <returns></returns>
        public static DataTable ConsultarPrenda(string ConsPrenda)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    if (ConsPrenda == string.Empty)
                    {
                        var query_where = (from a in contexto.Prendas
                                           select a).Distinct().ToList();
                        fichero = query_where;
                        if (fichero.Count > 0)
                        { 
                            foreach (var item in fichero)
                            {
                                string a = item.NombrePrendas.ToString();
                                VistaModeloPrendas.Add(a);

                            }
                        }
                    }
                    else
                    {

                        var query_where1 = (from a in contexto.Prendas
                                            where a.NombrePrendas.Contains(ConsPrenda.Trim())
                                            select a).Distinct().ToList();
                        fichero = query_where1;
                        if (fichero.Count > 0)
                        { 
                            foreach (var item in fichero)
                            {
                                string a = item.NombrePrendas.ToString();
                                VistaModeloPrendas.Add(a);

                            }
                        }
                    }
                    if (VistaModeloPrendas.Count > 0)
                    {
                        ficheroPrenda = LlenarResultado(VistaModeloPrendas);
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
                ficheroPrenda = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            VistaModeloPrendas.Clear();
            fichero.Clear();
            return ficheroPrenda;
        }
        /// <summary>
        /// Busca prendas por aproximacion
        /// </summary>
        /// <param name="ConsPrenda"></param>
      
        public static void BuscarPrenda(string ConsPrenda)
        {
            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    var query_where1 = from a in contexto.Prendas
                                       where a.NombrePrendas.Contains(ConsPrenda.Trim())
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombrePrendas != null && a.NombrePrendas.Contains(ConsPrenda.Trim()))
                        {
                            PrendasViewModel.IdPren = a.IdPrendas;
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
        /// <param name="ConsPrenda"></param>
        public static void BuscarExactoPrenda(string ConsPrenda)
        {
            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    var query_where1 = from a in contexto.Prendas
                                       where a.NombrePrendas == ConsPrenda.Trim()
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombrePrendas != null && a.NombrePrendas == ConsPrenda.Trim())
                        {
                            PrendasViewModel.IdPren = a.IdPrendas;
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
        /// Modifica el tipo de prenda
        /// </summary>
        /// <param name="idregistro"></param>
        /// <param name="prendaModificada"></param>
        public static void ModificarPrenda(int idregistro, string prendaModificada)
        {
            try
            {
                var cliente = new Prendas { IdPrendas = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.Prendas.Attach(cliente);
                    cliente.NombrePrendas= prendaModificada;
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
        public static void EliminarPrenda(int idregistro)
        {
            try
            {
                var cliente = new Prendas { IdPrendas = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.Prendas.Attach(cliente);
                    contexto.Prendas.Remove(cliente);
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
            dt.Columns.Add("Nombre Tipo de Prenda");

            foreach (string item in list)
            {
                dt.Rows.Add(item);
            }
            return dt;

        }

        #endregion
    }
}
