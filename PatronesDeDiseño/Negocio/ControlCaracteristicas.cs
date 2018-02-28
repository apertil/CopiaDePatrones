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
        //public static List<string> VistaModeloCaract = new List<string>();
        public static DataTable ficheroCaract;
        public static ArrayList intermedio = new ArrayList();

        #endregion

        #region "3.- Metodos Publicos de la clase

        /// <summary>
        /// Insertar Nueva Caracteristica
        /// </summary>
        /// <param name="NuevaCaract"></param>
        public static void InsertarCaracteristica(string NuevaCaract)
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
        public static DataTable ConsultarCaracteristica(string ConsCaract)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    if (ConsCaract == string.Empty)
                    {
                        var query_where = (from a in contexto.TiposCaracteristicas
                                           select a).Distinct().ToList();
                        fichero = query_where;

                        foreach (var item in fichero)
                        {
                            List<string> VistaModeloCaract = new List<string>();
                            string a = item.NombreCaracteristicas.ToString();
                            VistaModeloCaract.Add(a);
                            intermedio.Add(VistaModeloCaract);
                            cSuccessful = true;
                            cResultException = "";

                        }
                    }
                    else
                    {

                        var query_where1 = (from a in contexto.TiposCaracteristicas
                                            where a.NombreCaracteristicas.Contains(ConsCaract.Trim())
                                            select a).Distinct().ToList();
                        fichero = query_where1;
                        if (fichero.Count > 0)
                        {
                            foreach (var item in fichero)
                            {
                                List<string> VistaModeloCaract = new List<string>();
                                string a = item.NombreCaracteristicas.ToString();
                                VistaModeloCaract.Add(a);
                                intermedio.Add(VistaModeloCaract);
                                cSuccessful = true;
                                cResultException = "";
                            }
                        }
                    }
                    if (intermedio.Count > 0)
                    {

                        ficheroCaract = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = "No se ha encontrado la Característica";
                        cSuccessful = false;
                    }

                }

            }
            catch (Exception ex)
            {
                ficheroCaract = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            fichero.Clear();
            fichero = null;
            return ficheroCaract;
        }
        
               
        /// <summary>
        /// Busqueda exacta del elemento para no modificar o borrar el elemento equivocado
        /// </summary>
        /// <param name="ConsPrenda"></param>
        public static DataTable ConsultarExactoCaracteristica(string ConsCaract)
        {
            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    var query_where1 = (from a in contexto.TiposCaracteristicas
                                       where a.NombreCaracteristicas.Contains(ConsCaract.Trim().ToLower())
                                       select a).Distinct().ToList();
                    fichero = query_where1;
                    if (fichero.Count > 0)
                    {
                        foreach (var item in fichero)
                        {

                            if (item.NombreCaracteristicas != null && item.NombreCaracteristicas.ToLower() == ConsCaract.Trim().ToLower())
                            {
                                List<string> VistaCaract = new List<string>();
                                TCaractViewModel.IdTipCar = item.IdTiposCaract;
                                string a = item.NombreCaracteristicas.ToString();
                                VistaCaract.Add(a);
                                intermedio.Add(VistaCaract);
                                cSuccessful = true;
                                cResultException = "";
                            }
                        }
                    }
                    if (intermedio.Count > 0)
                    {
                        ficheroCaract = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = "No se ha encontrado la Característica";
                        cSuccessful = false;
                    }

                }
            }
            catch (Exception ex)
            {
                ficheroCaract =  null;
                cResultException = ex.ToString();
                cSuccessful = false;
            }
            intermedio.Clear();
            fichero.Clear();
            fichero = null;
            return ficheroCaract;
        }

        /// <summary>
        /// Modifica el tipo de prenda
        /// </summary>
        /// <param name="idregistro"></param>
        /// <param name="prendaModificada"></param>
        public static void ModificarCaracteristica(int idregistro, string CaractModificada)
        {
            try
            {
                var cliente = new TiposCaracteristicas { IdTiposCaract = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
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
        public static void EliminarCaracteristica(int idregistro)
        {
            try
            {
                var cliente = new TiposCaracteristicas { IdTiposCaract = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
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
        private static DataTable LlenarResultado(ArrayList Datos)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo de Características");

            foreach (List<string> item in Datos)
            {
                DataRow row = dt.NewRow();
                row["Tipo de Características"] = item[0];
                dt.Rows.Add(row);
            }
            return dt;

        }

        #endregion
    }
}
