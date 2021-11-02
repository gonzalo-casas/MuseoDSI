using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;
namespace MuseoDSI.Clases
{
    class Exposicion
    {
        public int idExposicion { get; set; }
        public int nroSede { get; set; }
        public int idTipoExposicion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public string nombre { get; set; }
        public string idPublico { get; set; }

        public List<Exposicion> Exposiciones = new List<Exposicion>();
        Backend _BD = new Backend();
        public List<Exposicion> BuscarListaDeExposiciones()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Exposicion";

            tabla = _BD.Consulta(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)
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

            List<Exposicion> ListaExposicionesVigentes = new List<Exposicion>();

        private DateTime ObtenerFechaActual()
        {
            string fechaActual = DateTime.Today.ToString("d");
            return DateTime.Parse(fechaActual);
        }

        TipoExposicion tipoExposicion = new TipoExposicion();

        public List<Exposicion> ComprobarVigencia (List<Exposicion> lista)
        {
            DateTime fechaHoy = ObtenerFechaActual();
            for( int i = 0; i < lista.Count; i++)
            {
                if (lista[i].fechaFin < fechaHoy)
                {
                    ListaExposicionesVigentes.Add(lista[i]);
                }
            }
            ListaExposicionesVigentes = tipoExposicion.BuscarExpoTipoTemp(ListaExposicionesVigentes);
            return ListaExposicionesVigentes;
        }
        DetalleExposicion de = new DetalleExposicion();
       
        public int CalcularDuracionEstimada(List<Exposicion> lista)
        {
            int duracion = de.CalcularDuracionEstimada(lista);
            return duracion;
        }




    }
}
