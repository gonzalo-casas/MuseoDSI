using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using MuseoDSI.Datos.EsquemaPersistencia.Daos;

namespace MuseoDSI.Clases
{
   public class Empleado
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

        public List<Empleado> ListaDeEmpleados = new List<Empleado>();

        private IEmpleado dao;
        public Empleado() // cto tab tab genera constructor automaticamente
        {
            dao = new EmpleadoDao();
        }
        public List<Empleado> LlenarListaEmpleados()
        {
            return dao.LlenarListaEmpleados();
        }

        public string VerificarCargo(int idCargo)
        {
            string cargo = "";
            if (idCargo == 2)
            {
                cargo = "Guia";
            }
            if (idCargo == 1)
            {
                cargo = "Responsable Visitas";
            }
            
            return cargo;
        }


    }
}
