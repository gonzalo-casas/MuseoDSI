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
        public List<Exposicion> ListaExposicion = new List<Exposicion>();
        public List<DetalleExposicion> ListaDetalleExposicion = new List<DetalleExposicion>();
        

        public List<Sede> BuscarlistaSedes()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Sede";
            tabla = Backend.obtenerInstancia().Consulta(sql);
            ListaSede.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Sede sede = new Sede();
                sede.nroSede = int.Parse(tabla.Rows[i]["nroSede"].ToString());
                sede.nombreSede = tabla.Rows[i]["nombreSede"].ToString();
                sede.CantidadMaximaPorGuia = int.Parse(tabla.Rows[i]["CantidadMaximaPorGuia"].ToString());
                sede.CantidadMaximaVisitantes = int.Parse(tabla.Rows[i]["CantidadMaximaVisitantes"].ToString());
                traerExposicionesPorSede(sede);


                ListaSede.Add(sede);
            }


            return ListaSede;
        }

      
        public void traerExposicionesPorSede(Sede sede)
        {

            sede.ListaExposiciones = new List<Exposicion>(); 
           
           

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Exposicion e JOIN  Sede s ON (s.nroSede = e.nroSede) WHERE s.nroSede = " + sede.nroSede ;

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
                exposicion.TipoExposicion = traerTipoExposicionPorExpo(int.Parse(tabla.Rows[i]["idTipoExposicion"].ToString()));
                traerDetalleExposicionPorExpo(exposicion);
          

                sede.ListaExposiciones.Add(exposicion); // meto  la exposicion a la lista que apunta la sede
            }



          


        }

        public void traerDetalleExposicionPorExpo(Exposicion expo)
        {

            expo.DetalleExposiciones = new List<DetalleExposicion>();
           

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM DetalleExposicion dt WHERE dt.idExposicion = " + expo.idExposicion;

            tabla = Backend.obtenerInstancia().Consulta(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
               DetalleExposicion detalleExpo = new DetalleExposicion();


               var idObra = int.Parse(tabla.Rows[i]["idObra"].ToString()); // ver q hacer con esto
               detalleExpo.idDetalle = int.Parse(tabla.Rows[i]["idDetalle"].ToString());
               detalleExpo.Obra = traerObraPorDE(idObra);
                expo.DetalleExposiciones.Add(detalleExpo);   // meto el detalleExposicion a la lista  que apunta la exposicion
            }

           
        }

        public TipoExposicion traerTipoExposicionPorExpo(int idTipoExposicion)
        {


            DataTable tabla = new DataTable();
            string sql = " SELECT * FROM TipoExposicion WHERE idTipoExposicion = " + idTipoExposicion;

            tabla = Backend.obtenerInstancia().Consulta(sql);

            TipoExposicion tipoExposicion = new TipoExposicion();

            tipoExposicion.idTipoExposicion = int.Parse(tabla.Rows[0]["idTipoExposicion"].ToString());
            tipoExposicion.descripcion = tabla.Rows[0]["descripcion"].ToString();
          


            return tipoExposicion;


        }


        public Obras traerObraPorDE(int idObra)
        {
            


            DataTable tabla = new DataTable();
            string sql = " SELECT* FROM obras WHERE idObras = " + idObra;

            tabla = Backend.obtenerInstancia().Consulta(sql);
          
                Obras obra = new Obras();

                obra.idObras = int.Parse(tabla.Rows[0]["idObras"].ToString());
                obra.nombre = tabla.Rows[0]["nombre"].ToString();
                obra.duracionExtendida = int.Parse(tabla.Rows[0]["duracionExtendida"].ToString());
                obra.duracionResumida = int.Parse(tabla.Rows[0]["duracionResumida"].ToString());


            return obra;
        }



        public List<Exposicion> BuscarExposiciones(string nombreSede, string tipoExposicion)
        {
            ListaExposicion.Clear();
            
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
