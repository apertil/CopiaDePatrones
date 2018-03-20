using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
   public  class ControlPatrones
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

        //  public static List<string> VistaModeloLanas = new List<string>();
        public static DataTable ficheroPatrones;
        public static ArrayList intermedio = new ArrayList();
        private static PatronesEntities contexto = new PatronesEntities();

        #endregion

        #region "3.- Variables de Carga de los combos"
        public static List<Patrones> ListaficheroPatrones;
        public static List<AutorPatron> ListaAutorPatron;
        public static List<Lanas> ListaLanas;
        public static List<Prendas> ListaPrendas;
        public static List<Revistas> ListaRevistas;
        public static List<TiposCaracteristicas> ListaCaracteristicas;
        public static List<TiposDeTejer> ListaTiposdeTejer;
        public static List<GeneroEdad> ListaGeneroEdad;
        #endregion

        #region "4.- Metodos Publicos de la clase

        public static List<AutorPatron> CargaComboAutor()
        {
        
            ListaAutorPatron = contexto.AutorPatron.ToList();
            ListaAutorPatron.Add(new AutorPatron { IdAutorPatron = 0, NombreAutor = "[Seleccione un Autor..]" });
            ListaAutorPatron = ListaAutorPatron.OrderBy(c => c.NombreAutor).ToList();
          
            return ListaAutorPatron;
        }

        public static List<Lanas> CargaComboLanas()
        {
            ListaLanas = contexto.Lanas.ToList();
            ListaLanas.Add(new Lanas { IdLana = 0, NombreLana = "[Selecione Grosor de la lana..]" });
            ListaLanas = ListaLanas.OrderBy(c => c.NombreLana).ToList();
            return ListaLanas;

        }

        public static List<Prendas> CargaComboPrendas()
        {
            ListaPrendas = contexto.Prendas.ToList();
            ListaPrendas.Add(new Prendas { IdPrendas = 0, NombrePrendas = "[Selecione Nombre Prenda...]" });
            ListaPrendas = ListaPrendas.OrderBy(c => c.NombrePrendas).ToList();
            return ListaPrendas; 
        }

        public static List<Revistas> CargaComboRevistas()
        {
            ListaRevistas = contexto.Revistas.ToList();
            ListaRevistas.Add(new Revistas { IdRevistas = 0, NombreRevista = "[Seleccione Revista...]" });
            ListaRevistas = ListaRevistas.OrderBy(c => c.NombreRevista).ToList();
            return ListaRevistas;
        }

        public static List<TiposCaracteristicas> CargaComboCaracteristicas()
        {
            ListaCaracteristicas = contexto.TiposCaracteristicas.ToList();
            ListaCaracteristicas.Add(new TiposCaracteristicas { IdTiposCaract = 0, NombreCaracteristicas = "[Seleccione Característica...]" });
            ListaCaracteristicas = ListaCaracteristicas.OrderBy(c => c.NombreCaracteristicas).ToList();
            return ListaCaracteristicas;
        }

        public static List<TiposDeTejer> CargaComboTipodeTejer()
        {
            ListaTiposdeTejer = contexto.TiposDeTejer.ToList();
            ListaTiposdeTejer.Add(new TiposDeTejer { IdTiposTejer = 0, NombreDeTejer = "[Seleccione Tipo de tejido...]" });
            ListaTiposdeTejer = ListaTiposdeTejer.OrderBy(c => c.NombreDeTejer).ToList();
            return ListaTiposdeTejer;
        }
        public static List<GeneroEdad> CargaComboGeneroEdad()
        {
            ListaGeneroEdad = contexto.GeneroEdad.ToList();
            ListaGeneroEdad.Add(new GeneroEdad { IdGenEd = 0, GenEdad = "[Seleccione Genero Edad...]" });
            ListaGeneroEdad = ListaGeneroEdad.OrderBy(c => c.GenEdad).ToList();
            return ListaGeneroEdad;
        }


        #endregion


    }
}
