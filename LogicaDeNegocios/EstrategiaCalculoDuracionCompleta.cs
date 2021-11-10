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

        public List<Exposicion> TomarExposicionesTempVig(int nroSede)
        {
            List<Exposicion> ListaExpos = sede.BuscarExposiciones(nroSede, "('1', '2')");
            return ListaExpos;
        }


        public int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas, string tipoExposicion)
        {
            int duracionEstimada = sede.BuscarDuracionExposiciones(ExposicionesSeleccionadas, tipoExposicion);
            return duracionEstimada;
        }
    }
}
