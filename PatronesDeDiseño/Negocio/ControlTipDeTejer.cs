using System;
using System.Collections.Generic;
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

        #endregion

    }
}
