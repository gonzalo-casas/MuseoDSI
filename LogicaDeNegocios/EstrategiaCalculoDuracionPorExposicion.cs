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

        public int CalcularDuracionEstimadaResv(List<Exposicion> ExposicionesSeleccionadas, string tipoExposicion)
        {
            int duracionEstimada = sede.BuscarDuracionExposiciones(ExposicionesSeleccionadas, tipoExposicion);
            return duracionEstimada;
        }



        public List<Exposicion> TomarExposicionesTempVig(int nombreSede) // cambiar nombreSede string
        {

            List<Exposicion> ListaExposTemporalesVigentes = sede.BuscarExposiciones(nombreSede, "('2')"); 
            return ListaExposTemporalesVigentes;
        }



    }
}
