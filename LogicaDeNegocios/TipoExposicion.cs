using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Clases
{
    public class TipoExposicion
    {
        public int idTipoReserva { get; set; }
        public string descripcion { get; set; }


        Publico publico = new Publico();
        //public List<Exposicion> esTemporal(List<Exposicion> lista)
        //{
        //    for(int i = 0; i < lista.Count; i++)
        //    {
        //        if(lista[i].idTipoExposicion == 1)
        //        {
        //            lista.RemoveAt(i);
        //        }
        //    }
            
        //    return lista;
        //}
    }
}
