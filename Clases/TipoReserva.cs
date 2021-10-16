using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;

namespace MuseoDSI.Clases
{
    class TipoReserva
    {
        Backend _BD = new Backend();
        public int idTipoReserva { get; set; }
        public string descripcion { get; set; }

        public List<TipoReserva> ListaTipoReserva = new List<TipoReserva>();
        public List<TipoReserva> BuscarlistaTipoReserva()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM TipoReserva";
            tabla = _BD.Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                TipoReserva tipoReserva = new TipoReserva();
                tipoReserva.idTipoReserva= int.Parse(tabla.Rows[i]["idTipoReserva"].ToString());
                tipoReserva.descripcion = tabla.Rows[i]["descripcion"].ToString();
                ListaTipoReserva.Add(tipoReserva);
            }

            return ListaTipoReserva;
        }

    }
}
