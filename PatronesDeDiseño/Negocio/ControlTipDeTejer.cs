﻿using System;
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

        public static void ModificarTiposDeTejer(string tipodetejer)
        {
            try
            {
                TiposDeTejer tiposdetejer = new TiposDeTejer();
                tiposdetejer.NombreDeTejer = tipodetejer;
                PatronEntit.Instancia.TiposDeTejer.Add(tiposdetejer);
                PatronEntit.Instancia.SaveChanges();
                cResultException = null;
                cSuccessful = true;
            }
            catch (Exception ex )
            {
                cResultException = ex.ToString();
                cSuccessful = false;
            }

        }
        public static DataTable ConsultarTipoDetejer(string TipoDetejer)
        {
            try
            {

                using (contexto contexto = new contexto())
                {
                    if (TipoDetejer == string.Empty)
                    {
                        var query_where = (from a in contexto.TiposDeTejer
                                           select a).Distinct().ToList();
                        fichero = query_where;

                        foreach (var item in fichero)
                        {
                            string a = item.NombreDeTejer.ToString();
                            VistaTipoDeTejer.Add(a);

                        }
                    }
                    else
                    {

                        var query_where1 = (from a in contexto.TiposDeTejer
                                            where a.NombreDeTejer.Contains(TipoDetejer.Trim())
                                            select a).Distinct().ToList();
                        fichero = query_where1;
                        foreach (var item in fichero)
                        {
                            string a = item.NombreDeTejer.ToString();
                            VistaTipoDeTejer.Add(a);

                        }

                    }

                    ficheroTipoDeTjer = LlenarResultado(VistaTipoDeTejer);



                    cResultException = null;
                    cSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                ficheroTipoDeTjer = null;
                cResultException = ex.ToString();
                cSuccessful = false;
            }
            return ficheroTipoDeTjer;
        }
        #endregion
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

    }
}
