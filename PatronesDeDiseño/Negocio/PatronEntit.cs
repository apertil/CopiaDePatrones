using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
    public class PatronEntit
    {
        private static contexto _instance;

        public PatronEntit()
        {
           
        }

        public static contexto Instancia
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new contexto();
                }
                return _instance;
        }   }
           
    }
}
