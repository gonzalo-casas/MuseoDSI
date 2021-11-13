using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Clases
{
    public class TipoExposicion
    {
        public int idTipoExposicion { get; set; }
        public string descripcion { get; set; }


       

        public bool esTemporal()
        {

            return this.idTipoExposicion.Equals(2); // return true si es temporal...
           
        }

    }
}
