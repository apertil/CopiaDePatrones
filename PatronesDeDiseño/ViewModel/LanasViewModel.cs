using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ViewModel
{
   public partial class LanasViewModel : Lanas
   {
        public static int IndiceBuscaLanas { get; set; }
        public static string NombLana { get; set; }
        public static List<Lanas> LstLanas = new List<Lanas>();
   }
    
}
