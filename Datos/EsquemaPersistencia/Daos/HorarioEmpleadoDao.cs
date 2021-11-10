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
    class HorarioEmpleadoDao : IHorarioEmpleado
    {
        public List<HorarioEmpleado> ListaDeHorarioEmpleados = new List<HorarioEmpleado>();
        public List<HorarioEmpleado> LlenarListaHorarioEmpleados()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM HorarioEmpleado";
            tabla = Backend.obtenerInstancia().Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                HorarioEmpleado horarioEmpleado = new HorarioEmpleado();
                horarioEmpleado.idHorario = int.Parse(tabla.Rows[i]["idHorario"].ToString());
                horarioEmpleado.horaIngreso = DateTime.Parse(tabla.Rows[i]["horaIngreso"].ToString());
                horarioEmpleado.horaSalida = DateTime.Parse(tabla.Rows[i]["horaSalida"].ToString());
                ListaDeHorarioEmpleados.Add(horarioEmpleado);
            }
            return ListaDeHorarioEmpleados;
        }
    }
}
