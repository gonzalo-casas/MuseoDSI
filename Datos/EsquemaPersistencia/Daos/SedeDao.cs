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
    class SedeDao : ISede
    {
        public List<Sede> ListaSede = new List<Sede>();

        public List<Sede> BuscarlistaSedes()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Sede";
            tabla = Backend.obtenerInstancia().Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Sede sede = new Sede();
                sede.nroSede = int.Parse(tabla.Rows[i]["nroSede"].ToString());
                sede.nombreSede = tabla.Rows[i]["nombreSede"].ToString();
                sede.CantidadMaximaPorGuia = int.Parse(tabla.Rows[i]["CantidadMaximaPorGuia"].ToString());
                sede.CantidadMaximaVisitantes = int.Parse(tabla.Rows[i]["CantidadMaximaVisitantes"].ToString());

                ListaSede.Add(sede);
            }

            return ListaSede;
        }

        public List<Exposicion> ListaExposicion = new List<Exposicion>();
        Exposicion expo = new Exposicion();



        public List<Exposicion> BuscarExposiciones(string nombreSede, string tipoExposicion)
        {
            ListaExposicion.Clear();
            //int nroSede = nroSedee + 1;
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Exposicion e JOIN  Sede s ON (s.nroSede = e.nroSede) WHERE s.nombreSede = '" + nombreSede + "' AND idTipoExposicion in " + tipoExposicion;

            tabla = Backend.obtenerInstancia().Consulta(sql);
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
                ListaExposicion.Add(exposicion);
            }
           // getExpovigente 
            return ListaExposicion;


        }
    }
}
