using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Datos.EsquemaPersistencia.Interfaz
{
    interface IHorarioEmpleado
    {
        List<HorarioEmpleado> LlenarListaHorarioEmpleados();
    }
}
