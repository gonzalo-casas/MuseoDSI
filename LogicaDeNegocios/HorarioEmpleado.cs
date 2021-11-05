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
    class HorarioEmpleado
    {
        public int idHorario { get; set; }
        public DateTime horaIngreso { get; set; }
        public DateTime horaSalida { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

        private IHorarioEmpleado dao;

        public List<HorarioEmpleado> ListaDeHorarioEmpleados = new List<HorarioEmpleado>();

        public HorarioEmpleado()
        {
            dao = new HorarioEmpleadoDao();
        }

        public List<HorarioEmpleado> LlenarListaHorarioEmpleados()
        {
            return dao.LlenarListaHorarioEmpleados();
        }

        public string VerificarHorario(List<HorarioEmpleado> ListaHorario, int idHorarioGuia, DateTime horarioSeleccionado)
        {

            string respuesta = "";
            for (int i = 0; i < ListaHorario.Count; i++)
            {
                if (idHorarioGuia == ListaHorario[i].idHorario)
                {
                    if (horarioSeleccionado >= ListaHorario[i].horaIngreso && horarioSeleccionado <= ListaHorario[i].horaSalida)
                    {
                        respuesta = "Validado";
                    }
                    else
                    {
                        respuesta = "No Validado";
                    }

                }
            }
            return respuesta;
        }
    }
}

