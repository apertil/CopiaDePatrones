using PatronesDeDiseño.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
    public class ControlCaracteristicas
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
        public static List<TiposCaracteristicas> fichero;
        public static List<string> VistaModeloCaract = new List<string>();
        public static DataTable ficheroCaract;

        #endregion

        #region "3.- Metodos Publicos de la clase

        /// <summary>
        /// Nueva prenda en base de datos
        /// </summary>
        /// <param name="NuevaPrenda"></param>
        public static void InsertarPrenda(string NuevaCaract)
        {
            try
            {
                TiposCaracteristicas TPrenda = new TiposCaracteristicas();
                TPrenda.NombreCaracteristicas = NuevaCaract;
                PatronEntit.Instancia.TiposCaracteristicas.Add(TPrenda);
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
        public static DataTable ConsultarPrenda(string ConsCaract)
        {

            try
            {
                using (contexto contexto = new contexto())
                {
                    if (ConsCaract == string.Empty)
                    {
                        var query_where = (from a in contexto.TiposCaracteristicas
                                           select a).Distinct().ToList();
                        fichero = query_where;

                        foreach (var item in fichero)
                        {
                            string a = item.NombreCaracteristicas.ToString();
                            VistaModeloCaract.Add(a);

                        }
                    }
                    else
                    {

                        var query_where1 = (from a in contexto.TiposCaracteristicas
                                            where a.NombreCaracteristicas.Contains(ConsCaract.Trim())
                                            select a).Distinct().ToList();
                        fichero = query_where1;
                        foreach (var item in fichero)
                        {
                            string a = item.NombreCaracteristicas.ToString();
                            VistaModeloCaract.Add(a);

                        }

                    }

                    ficheroCaract = LlenarResultado(VistaModeloCaract);
                    cResultException = null;
                    cSuccessful = true;
                }

            }
            catch (Exception ex)
            {
                ficheroCaract = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }

            return ficheroCaract;
        }
        /// <summary>
        /// Busca prendas por aproximacion
        /// </summary>
        /// <param name="ConsPrenda"></param>

        public static void BuscarPrenda(string ConsCaract)
        {
            try
            {
                using (contexto contexto = new contexto())
                {
                    var query_where1 = from a in contexto.TiposCaracteristicas
                                       where a.NombreCaracteristicas.Contains(ConsCaract.Trim())
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombreCaracteristicas != null && a.NombreCaracteristicas.Contains(ConsCaract.Trim()))
                        {
                            TCaractViewModel.IdTipCar = a.IdTiposCaract;
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
        public static void BuscarExactoPrenda(string ConsCaract)
        {
            try
            {
                using (contexto contexto = new contexto())
                {
                    var query_where1 = from a in contexto.TiposCaracteristicas
                                       where a.NombreCaracteristicas.Contains(ConsCaract.Trim())
                                       select a;

                    foreach (var a in query_where1)
                    {
                        if (a.NombreCaracteristicas != null && a.NombreCaracteristicas == ConsCaract.Trim())
                        {
                            TCaractViewModel.IdTipCar = a.IdTiposCaract;
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
        public static void ModificarPrenda(int idregistro, string CaractModificada)
        {
            try
            {
                var cliente = new TiposCaracteristicas { IdTiposCaract = idregistro };
                using (contexto contexto = new contexto())
                {
                    contexto.TiposCaracteristicas.Attach(cliente);
                    cliente.NombreCaracteristicas = CaractModificada;
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
                var cliente = new TiposCaracteristicas { IdTiposCaract = idregistro };
                using (contexto contexto = new contexto())
                {
                    contexto.TiposCaracteristicas.Attach(cliente);
                    contexto.TiposCaracteristicas.Remove(cliente);
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
            dt.Columns.Add("Tipo de Características");

            foreach (string item in list)
            {
                dt.Rows.Add(item);
            }
            return dt;

        }

        #endregion
    }
}
