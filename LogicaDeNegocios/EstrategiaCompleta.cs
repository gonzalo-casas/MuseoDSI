using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.LogicaDeNegocios
{
    class EstrategiaCompleta : IEstrategiaTipoVisita
    {
  

        public int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas)
        {
            int duracionEstimada;
            //int duracionEstimada = sede.BuscarDuracionExposiciones(ExposicionesSeleccionadas, "completa");
            //return duracionEstimada;
           return duracionEstimada = 0;
        }

        public List<Exposicion> TomarExposiciones(Sede sedeSeleccionada)
        {
            return TomarExposicionesCompleta(sedeSeleccionada);
        }


        public List<Exposicion> TomarExposicionesCompleta(Sede sedeSeleccionada)
        {
            List<Exposicion> ListaExpos = sedeSeleccionada.BuscarExposicionesCompleta();
            return ListaExpos;
        }


    }
}
