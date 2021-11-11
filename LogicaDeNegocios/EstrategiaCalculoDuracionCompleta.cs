using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.LogicaDeNegocios
{
    class EstrategiaCalculoDuracionCompleta : IEstrategiaCalculoDuracion
    {
        Sede sede = new Sede();

        public List<Exposicion> TomarExposicionesTempVig(string nombreSede)
        {
            List<Exposicion> ListaExpos = sede.BuscarExposiciones(nombreSede, "('1', '2')");
            return ListaExpos;
        }


        public int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas)
        {
            int duracionEstimada = sede.BuscarDuracionExposiciones(ExposicionesSeleccionadas, "completa");
            return duracionEstimada;
        }
    }
}
