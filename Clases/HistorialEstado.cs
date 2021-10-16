using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Clases
{
    class HistorialEstado
    {
        public int idHistorial { get; set; }
        public int idEstado { get; set; }
        public int idObra { get; set; }
        public int idReserva { get; set; }
        public DateTime fechaHoraDesde { get; set; }
        public DateTime fechaHoraHasta { get; set; }

        public List<HistorialEstado> ListaHistoriales = new List<HistorialEstado>();
        public void newHistorialEstado(int idHistorial,int idEstado,int idObra,int idreserva,DateTime fechaHoraDesde,DateTime fechaHoraHasta)
        {
            HistorialEstado HE = new HistorialEstado();
            HE.idHistorial = idHistorial;
            HE.idEstado = idEstado;
            HE.idObra = idObra;
            HE.idReserva = idReserva;
            HE.fechaHoraDesde = fechaHoraDesde;
            HE.fechaHoraDesde = fechaHoraHasta;
            ListaHistoriales.Add(HE);
            
        }
    }
}
