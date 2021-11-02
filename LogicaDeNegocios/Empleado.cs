using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;

namespace MuseoDSI.Clases
{
    class Empleado
    {
        public int dni { get; set; }
        public int idTipoDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string sexo { get; set; }
        public int telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idHorario { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int idCargo { get; set; }

        Backend _BD = new Backend();

        public List<Empleado> ListaDeEmpleados = new List<Empleado>();
        public List<Empleado> LlenarListaEmpleados()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Empleado";
            tabla = _BD.Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Empleado empleado = new Empleado();
                empleado.dni = int.Parse(tabla.Rows[i]["dni"].ToString());
                empleado.nombre = tabla.Rows[i]["nombre"].ToString();
                empleado.idHorario = int.Parse(tabla.Rows[i]["idHorario"].ToString());
                empleado.idCargo = int.Parse(tabla.Rows[i]["idCargo"].ToString());
                ListaDeEmpleados.Add(empleado);
            }
            return ListaDeEmpleados;
        }

        public string VerificarGuia(int idCargo)
        {
            string cargo = "";
            if (idCargo == 1)
            {
                cargo = "Guia";
            }
            
            return cargo;
        }


    }
}
