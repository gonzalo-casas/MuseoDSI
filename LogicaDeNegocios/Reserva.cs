using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using MuseoDSI.Datos.EsquemaPersistencia.Daos;

namespace MuseoDSI.Clases
{
    class Reserva
    {
        public int idReserva { get; set; }
        public int nroSede { get; set; }
        public int idEscuela { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime fechaReserva { get; set; }
        public int cantidadAlumnos { get; set; }
        public int idTipoReserva { get; set; }
        public int idEstado { get; set; }

        private IReserva dao;
        public Reserva()
        {
            dao = new ReservaDao();
        }
        public List<Reserva> ListaDeReservas = new List<Reserva>();
        public List<Reserva> ListaReservas()
        {
            return dao.ListaReservas();
        }

        private void AgregarNuevaReserva(Reserva reserva)
        {
            ListaDeReservas.Add(reserva);
        }
        HistorialEstado HE = new HistorialEstado();
        AsignacionVisita AV = new AsignacionVisita();



        public Reserva nuevaReserva(int idReserva, int nroSede, int idEscuela, DateTime horaInicio, DateTime fechaReserva, int CantidadAlumnos, int idTipoReserva, int idEstado, List<Empleado> empleados, TimeSpan duracion)
        {
            Reserva reserva = new Reserva();
            reserva.idReserva = idReserva;
            reserva.nroSede = nroSede;
            reserva.idEscuela = idEscuela;
            reserva.horaInicio = horaInicio;
            reserva.fechaReserva = fechaReserva;
            reserva.cantidadAlumnos = CantidadAlumnos;
            reserva.idTipoReserva = idTipoReserva;
            reserva.idEstado = idEstado;

            HE.newHistorialEstado(1, 1, 0, idReserva, DateTime.Now, DateTime.Now);
            
            DateTime desde = fechaReserva.Date.Add(horaInicio.TimeOfDay);
            DateTime horaFin = horaInicio.Add(duracion);
            DateTime hasta = fechaReserva.Date.Add(horaFin.TimeOfDay);
            AV.AsignarVisita(desde, hasta, empleados, idReserva);


            dao.CrearReserva(idReserva, nroSede, idEscuela, horaInicio, fechaReserva, CantidadAlumnos, idTipoReserva, idEstado);

            return reserva;
        }

    }
}
