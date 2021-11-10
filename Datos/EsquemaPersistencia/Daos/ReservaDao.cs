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
    class ReservaDao : IReserva
    {
        public List<Reserva> ListaDeReservas = new List<Reserva>();

        public List<Reserva> ListaReservas()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Reserva";
            tabla = Backend.obtenerInstancia().Consulta(sql);
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

        public void CrearReserva(int idReserva, int nroSede, int idEscuela, DateTime horaInicio, DateTime fechaReserva, int CantidadAlumnos, int idTipoReserva, int idEstado)
        {
            string sql = @"INSERT INTO Reserva 
                           VALUES (" + idReserva.ToString() + "," + nroSede.ToString() + "," + idEscuela.ToString() + ", '" + horaInicio.ToString("HH:mm:ss") + "','" + fechaReserva.ToString("yyyy-MM-dd") + "'," + CantidadAlumnos.ToString() + "," + idTipoReserva.ToString() + "," + idEstado.ToString() + ")";
            Backend.obtenerInstancia().EjecutarSQL(sql);
        }

    }
}
