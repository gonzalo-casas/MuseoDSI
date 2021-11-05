using MuseoDSI.Clases;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoDSI.Datos.EsquemaPersistencia.Daos
{
    class ExposicionDao : IExposicion
    {
        public List<Exposicion> Exposiciones = new List<Exposicion>();
        public List<Exposicion> BuscarListaDeExposiciones()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Exposicion";

            tabla = Backend.obtenerInstancia().Consulta(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)  // aca implenta el gethorarioHabilitado y getPublicoDestino
            {
                Exposicion exposicion = new Exposicion();
                exposicion.idExposicion = int.Parse(tabla.Rows[i]["idExposicion"].ToString());
                exposicion.nroSede = int.Parse(tabla.Rows[i]["nroSede"].ToString());
                exposicion.nombre = tabla.Rows[i]["nombreExposicion"].ToString();
                exposicion.idPublico = tabla.Rows[i]["idPublico"].ToString();
                exposicion.horaInicio = DateTime.Parse(tabla.Rows[i]["horaInicio"].ToString());
                exposicion.horaFin = DateTime.Parse(tabla.Rows[i]["horaCierre"].ToString());
                exposicion.fechaInicio = DateTime.Parse(tabla.Rows[i]["fechaInicio"].ToString());
                exposicion.fechaFin = DateTime.Parse(tabla.Rows[i]["fechaCierre"].ToString());
                Exposiciones.Add(exposicion);
            }

            return Exposiciones;
        }
    }
}
