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
            int duracionEstimada = 0;
            foreach (Exposicion expo in ExposicionesSeleccionadas)  // mientras haya exposiciones
            {
                duracionEstimada += expo.BuscarDuracionResumidaObra();
            }

            return duracionEstimada;
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
