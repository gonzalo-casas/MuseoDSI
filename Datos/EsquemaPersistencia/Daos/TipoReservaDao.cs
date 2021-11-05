using MuseoDSI.Clases;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Datos.EsquemaPersistencia.Daos
{
    class TipoReservaDao : ITipoReserva
    {
        public List<TipoReserva> ListaTipoReserva = new List<TipoReserva>();
        public List<TipoReserva> BuscarlistaTipoReserva()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM TipoReserva";
            tabla = Backend.obtenerInstancia().Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                TipoReserva tipoReserva = new TipoReserva();
                tipoReserva.idTipoReserva = int.Parse(tabla.Rows[i]["idTipoReserva"].ToString());
                tipoReserva.descripcion = tabla.Rows[i]["descripcion"].ToString();
                ListaTipoReserva.Add(tipoReserva);
            }

            return ListaTipoReserva;
        }
    }
}
