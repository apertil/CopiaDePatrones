using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ViewModel
{
    class PatronesViewModel : Patrones
    {
        public static int idPatron { get; set; }
        public static string AutPat { get; set; }
        public static string GrosLAna { get; set; }
        public static string TipoPrenda { get; set; }
        public static string Revista { get; set; }
        public static string TipCaract { get; set; }
        public static string TipTejer { get; set; }
        public static string GenEd { get; set; }
        public static string RutaPatron { get; set; }

        public static DataTable TableAutor;

    }
}
