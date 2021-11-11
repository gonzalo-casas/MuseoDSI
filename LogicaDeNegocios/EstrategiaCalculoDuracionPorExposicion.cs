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
            int duracionEstimada = sede.BuscarDuracionExposiciones(ExposicionesSeleccionadas, "porExposicion"); // le pide a sede que busque la duracion de las exposiciones 
            return duracionEstimada;
        }



        public List<Exposicion> TomarExposicionesTempVig(string nombreSede) // cambiar nombreSede string
        {

            List<Exposicion> ListaExposTemporalesVigentes = sede.BuscarExposiciones(nombreSede, "('2')");  // le pide a sede seleccionada  que busque las exposiciones
            return ListaExposTemporalesVigentes; // se lo devuelve a gestor la lista de exposiciones para que despues se lo pase a pantalla
        }

       


    }
}
