using MuseoDSI.Datos.EsquemaPersistencia.Daos;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Clases
{   
    class AsignacionVisita
    {
        private IAsignacionVisita dao;
        public AsignacionVisita()
        {
            dao = new AsignacionVisitaDao();
        }

        public DateTime fechahoraDesde { get; set; }
        public DateTime fechahoraHasta { get; set; }
        public int idEmpleado { get; set; }
        public int idReserva { get; set; }
        
        public void AsignarVisita(DateTime desde, DateTime hasta, List<Empleado> empleados, int idReserva)
        {
            dao.AsignarVisita(desde, hasta, empleados, idReserva);
        }
    }
}
