using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;

namespace MuseoDSI.Clases
{
    class HorarioEmpleado
    {
        public int idHorario { get; set; }
        public DateTime horaIngreso { get; set; }
        public DateTime horaSalida { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        Backend _BD = new Backend();

        public List<HorarioEmpleado> ListaDeHorarioEmpleados = new List<HorarioEmpleado>();
        public List<HorarioEmpleado> LlenarListaHorarioEmpleados()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM HorarioEmpleado";
            tabla = _BD.Consulta(sql);

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

