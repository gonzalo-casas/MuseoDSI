using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using MuseoDSI.Datos.EsquemaPersistencia.Daos;

namespace MuseoDSI.Clases
{
    class TipoReserva
    {
        public int idTipoReserva { get; set; }
        public string descripcion { get; set; }

        private ITipoReserva dao;
        public TipoReserva()
        {
            dao = new TipoReservaDao();
        }

        public List<TipoReserva> ListaTipoReserva = new List<TipoReserva>();

        public List<TipoReserva> BuscarlistaTipoReserva()
        {
            return dao.BuscarlistaTipoReserva();
        }

    }
}
