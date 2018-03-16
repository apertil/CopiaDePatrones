using System;
using PatronesDeDiseño.ViewModel;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
   public class ControlRevistas
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
        
       // public static 
        public static DataTable ficheroRevistas;
        public static ArrayList intermedio = new ArrayList();
        private static PatronesEntities contexto = new PatronesEntities();
        public static List<Revistas> fichero;
        #endregion


        public static void InsertarRevista(string NuevaRevista, string fautor)
        {
            try
            {
                Revistas TRevis = new Revistas();
                TRevis.NombreRevista = NuevaRevista;
                TRevis.Autor = fautor != string.Empty ? fautor : null;
                PatronEntit.Instancia.Revistas.Add(TRevis);
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
        public static DataTable ConsultarRevista(string ConsPrenda)
        {

            try
            {
               
                    if (ConsPrenda == string.Empty)
                    {

                        fichero = contexto.Revistas.ToList();

                        foreach (var item in fichero)
                        {
                            List<string> VistaRevistas = new List<string>();
                            string a = item.NombreRevista.ToString();
                            string b = item.Autor.ToString();
                            VistaRevistas.Add(a);
                            VistaRevistas.Add(b);
                            intermedio.Add(VistaRevistas);
                        }

                    }
                    else
                    {

                        fichero = contexto.Revistas.ToList();
                    
                            foreach (var item in fichero)
                            {
                                List<string> VistaRevistas = new List<string>();
                                string a = item.NombreRevista.ToString();
                                string b = item.Autor.ToString();
                                VistaRevistas.Add(a);
                                VistaRevistas.Add(b);
                                intermedio.Add(VistaRevistas);
                            }
                        

                    }
                    if (intermedio.Count > 0)
                    {
                        ficheroRevistas = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = "No se ha encontrado la revista";
                        cSuccessful = false;
                    }
                

            }
            catch (Exception ex)
            {
                ficheroRevistas = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            fichero.Clear();
            fichero = null;
            return ficheroRevistas;
        }

        public static void ModificarRevista(int idregistro, string RevistaModificada, string autorModificado)
        {
            try
            {
                var cliente = new Revistas { IdRevistas = idregistro };
                
                    contexto.Revistas.Attach(cliente);
                    cliente.NombreRevista = RevistaModificada;
                    cliente.Autor = autorModificado;
                    contexto.Configuration.ValidateOnSaveEnabled = false;
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

        public static DataTable ConsultarExactoRevista(string ConsPrenda)
        {

            try
            {
                fichero = contexto.Revistas.ToList();
                    foreach (var item in fichero)
                    {
                        if (item.NombreRevista != null && item.NombreRevista.ToLower() == ConsPrenda.Trim().ToLower())
                        { 
                            List<string> VistaRevistas = new List<string>();
                            RevistasViewModel.IdRevista = item.IdRevistas;
                            string a = item.NombreRevista.ToString();
                            string b = item.Autor.ToString();
                            VistaRevistas.Add(a);
                            VistaRevistas.Add(b);
                            intermedio.Add(VistaRevistas);
                            cSuccessful = true;
                            cResultException = "";
                        }
                    }
                        

                    if (intermedio.Count > 0)
                    {
                        ficheroRevistas = LlenarResultado(intermedio);
                        cResultException = null;
                        cSuccessful = true;
                    }
                    else
                    {
                        cResultException = "No se ha encontrado la revista";
                        cSuccessful = false;
                    }
                

            }
            catch (Exception ex)
            {
                ficheroRevistas = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            fichero.Clear();
            fichero = null;
            return ficheroRevistas;
        }

        public static void EliminarRevista(int idregistro)
        {
            try
            {
                var cliente = new Revistas { IdRevistas = idregistro };
                
                    contexto.Revistas.Attach(cliente);
                    contexto.Revistas.Remove(cliente);
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



        private static DataTable LlenarResultado(ArrayList Datos)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre Tipo de revista");
            dt.Columns.Add("Autor");

            foreach (List<string> item in Datos)
            {
                DataRow row = dt.NewRow();
                row["Nombre Tipo de revista"] = item[0];
                row["Autor"] = item[1];
                dt.Rows.Add(row);
            }
            return dt;

        }
    }
}
