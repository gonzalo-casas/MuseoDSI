using MuseoDSI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.LogicaDeNegocios
{
    class EstrategiaPorExposicion : IEstrategiaTipoVisita
    {
        Sede sede = new Sede();

        public int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas)
        {
            int duracionEstimada = 0;
            foreach (Exposicion expo in ExposicionesSeleccionadas)  // mientras haya exposiciones
            {
                duracionEstimada += expo.BuscarDuracionExtendidaObra();
            }

            return duracionEstimada;
        }

        public List<Exposicion> TomarExposiciones(Sede sedeSeleccionada)
        {
            return TomarExposicionesTempVig(sedeSeleccionada);
        }

        public List<Exposicion> TomarExposicionesTempVig(Sede sedeSeleccionada) 
        {

            List<Exposicion> ListaExposTemporalesVigentes = sedeSeleccionada.BuscarExposiciones();  // le pide a sede seleccionada  que busque las exposiciones
            return ListaExposTemporalesVigentes; // se lo devuelve a gestor la lista de exposiciones para que despues se lo pase a pantalla
        }

       


    }
}
