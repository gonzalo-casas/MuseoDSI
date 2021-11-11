using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.LogicaDeNegocios
{
    interface IEstrategiaTipoVisita
    {
        //int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas, string tipoExposicion);
        int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas);
        List<Exposicion> TomarExposiciones(string nroSede);
    }
}
