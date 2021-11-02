using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Clases
{
    class TipoExposicion
    {
        public int idTipoReserva { get; set; }
        public string descripcion { get; set; }


        Publico publico = new Publico();
        public List<Exposicion> BuscarExpoTipoTemp(List<Exposicion> lista)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                if(lista[i].idTipoExposicion == 2)
                {
                    lista.RemoveAt(i);
                }
            }
            //lista = publico.ObtenerPublico(lista);
            return lista;
        }
    }
}
