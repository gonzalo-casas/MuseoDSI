using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.LogicaDeNegocios
{
    class EstrategiaCalculoDuracionPorExposicion : IEstrategiaCalculoDuracion
    {
        Sede sede = new Sede();

        public int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas)
        {
            int duracionEstimada = sede.CalcularDuracionEstimada(ExposicionesSeleccionadas);
            return duracionEstimada;
        }



        public List<Exposicion> BuscarExposiciones(int nroSede)
        {

            List<Exposicion> ListaExpos = sede.BuscarListaExposicion(nroSede);
            return ListaExpos;
        }

    }
}
