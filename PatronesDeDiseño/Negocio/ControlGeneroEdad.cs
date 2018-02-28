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
    public class ControlGeneroEdad
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
        public static List<GeneroEdad> ficheroGeneroEdad;
        // public static 
        public static DataTable ficheroGenEd;
        public static ArrayList intermedio = new ArrayList();


        #endregion
        public static void InsertarGeneroEdad(string Ngenero)
        {
            try
            {
                GeneroEdad TGenEd = new GeneroEdad();
                TGenEd.GenEdad = Ngenero != string.Empty ? Ngenero : null;

                PatronEntit.Instancia.GeneroEdad.Add(TGenEd);
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

        public static DataTable ConsultarGenEdad(string Ngenero)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    if (Ngenero == string.Empty)
                    {
                        var query_where = (from a in contexto.GeneroEdad
                                           select a).Distinct().ToList();
                        ficheroGeneroEdad = query_where;

                        foreach (var item in ficheroGeneroEdad)
                        {
                            List<string> VistaGenEdad = new List<string>();

                            string a = item.GenEdad.ToString();
                            VistaGenEdad.Add(a);
                            intermedio.Add(VistaGenEdad);
                        }

                    }
                    else
                    {

                        var query_where1 = (from a in contexto.GeneroEdad
                                            where a.GenEdad.Contains(Ngenero.Trim())
                                            select a).Distinct().ToList();
                        ficheroGeneroEdad = query_where1;
                        if (ficheroGeneroEdad.Count > 0)
                        {
                            foreach (var item in ficheroGeneroEdad)
                            {
                                List<string> VistaGenEdad = new List<string>();
                                string a = item.GenEdad.ToString();
                                VistaGenEdad.Add(a);
                                intermedio.Add(VistaGenEdad);
                            }
                        }

                    }
                    if (intermedio.Count > 0)
                    {
                        ficheroGenEd = LlenarResultado(intermedio);
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
                ficheroGenEd = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            ficheroGeneroEdad.Clear();
            ficheroGeneroEdad = null;
            return ficheroGenEd;
        }

        public static DataTable ConsultarExactoGenEdad(string Ngenero)
        {

            try
            {
                using (PatronesEntities contexto = new PatronesEntities())
                {

                    var query_where1 = (from a in contexto.GeneroEdad
                                        where a.GenEdad.Contains(Ngenero.Trim())
                                        select a).Distinct().ToList();
                    ficheroGeneroEdad = query_where1;
                    if (ficheroGeneroEdad.Count > 0)
                    {
                        foreach (var item in ficheroGeneroEdad)
                        {
                            if (item.GenEdad != null && item.GenEdad.ToLower() == Ngenero.Trim().ToLower())
                            {
                                List<string> VistaGenEdad = new List<string>();
                                GeneroEdadViewModel.IdGenEdad = item.IdGenEd;
                                string a = item.GenEdad.ToString();
                                VistaGenEdad.Add(a);
                                intermedio.Add(VistaGenEdad);
                                cSuccessful = true;
                                cResultException = "";
                            }
                        }
                    }


                    if (intermedio.Count > 0)
                    {
                        ficheroGenEd = LlenarResultado(intermedio);
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
                ficheroGenEd = null;
                cResultException = ex.ToString();
                cSuccessful = false;

            }
            intermedio.Clear();
            ficheroGeneroEdad.Clear();
            ficheroGeneroEdad = null;
            return ficheroGenEd;
        }


        public static void ModificarGenEdad(int idregistro, string autorModificado)
        {
            try
            {
                var cliente = new GeneroEdad { IdGenEd = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.GeneroEdad.Attach(cliente);
                    cliente.GenEdad = autorModificado;
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

        public static void EliminarGenEdad(int idregistro)
        {
            try
            {
                var cliente = new GeneroEdad { IdGenEd = idregistro };
                using (PatronesEntities contexto = new PatronesEntities())
                {
                    contexto.GeneroEdad.Attach(cliente);
                    contexto.GeneroEdad.Remove(cliente);
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
            dt.Columns.Add("Nombre Genero Edad");
            
            foreach (List<string> item in Datos)
            {
                DataRow row = dt.NewRow();
                row["Nombre Genero Edad"] = item[0];
                dt.Rows.Add(row);
            }
            return dt;

        }








    }
}
