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
    class EmpleadoDao : IEmpleado
    {
        public List<Empleado> ListaDeEmpleados = new List<Empleado>();
        public List<Empleado> LlenarListaEmpleados()
        {

            string sql = "SELECT * FROM Empleado";
            DataTable tabla = Backend.obtenerInstancia().Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Empleado empleado = new Empleado();
                empleado.dni = int.Parse(tabla.Rows[i]["dni"].ToString());
                empleado.nombre = tabla.Rows[i]["nombre"].ToString();
                empleado.apellido = tabla.Rows[i]["apellido"].ToString();
                empleado.idHorario = int.Parse(tabla.Rows[i]["idHorario"].ToString());
                empleado.idCargo = int.Parse(tabla.Rows[i]["idCargo"].ToString());
                ListaDeEmpleados.Add(empleado);
            }
            return ListaDeEmpleados;
        }
    }
}
