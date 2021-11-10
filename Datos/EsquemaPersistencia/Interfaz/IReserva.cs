using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Datos.EsquemaPersistencia.Interfaz
{
    interface IReserva
    {
        List<Reserva> ListaReservas();

        void CrearReserva(int idReserva, int nroSede, int idEscuela, DateTime horaInicio, DateTime fechaReserva, int CantidadAlumnos, int idTipoReserva, int idEstado);
    }
}
