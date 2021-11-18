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
    class AsignacionVisitaDao : IAsignacionVisita
    {
        public void AsignarVisita(DateTime desde, DateTime hasta, int idEmpleado, int idReserva)
        {
            string insert = @"INSERT INTO AsignacionVisita 
                           VALUES (" + desde.ToString("yyyy-MM-dd HH:mm:ss") + "," + hasta.ToString("yyyy-MM-dd HH:mm:ss") + "," + idEmpleado.ToString() + ", '" + idReserva.ToString() + ")";
            Backend.obtenerInstancia().EjecutarSQL(insert);
        }
    }
}
