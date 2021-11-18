using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Datos.EsquemaPersistencia.Interfaz
{
    interface IAsignacionVisita
    {
        void AsignarVisita(DateTime desde, DateTime hasta, int idEmpleado, int idReserva);
    }
}
