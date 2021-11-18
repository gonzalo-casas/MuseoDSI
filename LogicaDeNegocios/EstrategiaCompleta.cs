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

        Sede sede = new Sede();

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
            List<Exposicion> ListaExpos = sedeSeleccionada.BuscarExposicionesCompleta();
            return ListaExpos;
        }


        //public List<Exposicion> TomarExposicionesCompleta(Sede sedeSeleccionada)
        //{
           
        //}


    }
}
