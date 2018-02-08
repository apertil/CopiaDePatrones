using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.Negocio
{
    public class PatronEntit
    {
        private static PatronesEntities _instance;

        public PatronEntit()
        {
           
        }

        public static PatronesEntities Instancia
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new PatronesEntities();
                }
                return _instance;
        }   }
           
    }
}
