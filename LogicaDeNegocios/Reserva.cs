using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI;
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

        Backend _BD = new Backend();
        public List<Reserva> ListaDeReservas = new List<Reserva>();
        public List<Reserva> ListaReservas()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Reserva";
            tabla = _BD.Consulta(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Reserva reserva = new Reserva();
                    reserva.idReserva = int.Parse(tabla.Rows[i]["idReserva"].ToString());
                    reserva.fechaReserva = DateTime.Parse(tabla.Rows[i]["fechaReserva"].ToString());
                    reserva.cantidadAlumnos = int.Parse(tabla.Rows[i]["cantidadAlumnos"].ToString());
                    reserva.horaInicio = DateTime.Parse(tabla.Rows[i]["horaInicio"].ToString());
                    ListaDeReservas.Add(reserva);
                }
            return ListaDeReservas;
        }

        private void AgregarNuevaReserva(Reserva reserva)
        {
            ListaDeReservas.Add(reserva);
        }
        HistorialEstado HE = new HistorialEstado();
        public Reserva nuevaReserva(int idReserva, int nroSede, int idEscuela, DateTime horaInicio, DateTime fechaReserva, int CantidadAlumnos, int idTipoReserva, int idEstado)
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
            

            return reserva;
        }

    }
}
