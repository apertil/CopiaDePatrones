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
    public class ControlAutores
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
        public static List<AutorPatron> ficheroAutPatron;
        // public static 
        public static DataTable ficheroAutores;
        public static ArrayList intermedio = new ArrayList();


        #endregion
        public static void InsertarAutor(string Nautor)
        {
            try
            {
                AutorPatron TAutPat = new AutorPatron();
                TAutPat.NombreAutor = Nautor != string.Empty ? Nautor : null;
               
                PatronEntit.Instancia.AutorPatron.Add(TAutPat);
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

        public static DataTable ConsultarAutor(string ConsAutor)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    if (ConsAutor == string.Empty)
                    {
                        var query_where = (from a in contexto.AutorPatron
                                           select a).Distinct().ToList();
                        ficheroAutPatron = query_where;

                        foreach (var item in ficheroAutPatron)
                        {
                            List<string> VistaAutor = new List<string>();
                            
                            string a = item.NombreAutor.ToString();
                            VistaAutor.Add(a);
                            intermedio.Add(VistaAutor);
                        }

                    }
                    else
                    {

                        var query_where1 = (from a in contexto.AutorPatron
                                            where a.NombreAutor.Contains(ConsAutor.Trim())
                                            select a).Distinct().ToList();
                        ficheroAutPatron = query_where1;
                        if (ficheroAutPatron.Count > 0)
                        {
                            foreach (var item in ficheroAutPatron)
                            {
                                List<string> VistaAutor = new List<string>();
                                string a = item.NombreAutor.ToString();
                                VistaAutor.Add(a);
                                intermedio.Add(VistaAutor);
                            }
                        }

                    }
                    if (intermedio.Count > 0)
                    {
                        ficheroAutores = LlenarResultado(intermedio);
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
                ficheroAutores = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            ficheroAutPatron.Clear();
            ficheroAutPatron = null;
            return ficheroAutores;
        }

        public static DataTable ConsultarExactoAutores(string ConsAutor)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {

                    var query_where1 = (from a in contexto.AutorPatron
                                        where a.NombreAutor.Contains(ConsAutor.Trim())
                                        select a).Distinct().ToList();
                    ficheroAutPatron = query_where1;
                    if (ficheroAutPatron.Count > 0)
                    {
                        foreach (var item in ficheroAutPatron)
                        {
                            if (item.NombreAutor != null && item.NombreAutor.ToLower() == ConsAutor.Trim().ToLower())
                            {
                                List<string> VistaAutor = new List<string>();
                                AutorViewModel.IdAutPatron = item.IdAutorPatron;
                                string a = item.NombreAutor.ToString();
                                VistaAutor.Add(a);
                                intermedio.Add(VistaAutor);
                                cSuccessful = true;
                                cResultException = "";
                            }
                        }
                    }


                    if (intermedio.Count > 0)
                    {
                        ficheroAutores = LlenarResultado(intermedio);
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
                ficheroAutores = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            ficheroAutPatron.Clear();
            ficheroAutPatron = null;
            return ficheroAutores;
        }


        public static void ModificarAutor(int idregistro, string autorModificado)
        {
            try
            {
                var cliente = new AutorPatron { IdAutorPatron = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.AutorPatron.Attach(cliente);
                    cliente.NombreAutor = autorModificado;
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

        public static void EliminarAutor(int idregistro)
        {
            try
            {
                var cliente = new AutorPatron { IdAutorPatron = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.AutorPatron.Attach(cliente);
                    contexto.AutorPatron.Remove(cliente);
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
            dt.Columns.Add("Nombre Autor Patron");
           

            foreach (List<string> item in Datos)
            {
                DataRow row = dt.NewRow();
                row["Nombre Autor Patron"] = item[0];
                dt.Rows.Add(row);
            }
            return dt;

        }
    }
}
