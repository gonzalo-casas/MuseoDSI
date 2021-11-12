using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using MuseoDSI.Datos.EsquemaPersistencia.Daos;

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

        public TipoExposicion TipoExposicion { get => _tipoExposicion; set => _tipoExposicion = value; }
        public Empleado Empleado { get => _empleado; set => _empleado = value; }
        public Publico PublicoDestino { get => _publicoDestino; set => _publicoDestino = value; }

        public List<DetalleExposicion> DetalleExposiciones { get; set; }
        //public List<DetalleExposicion> DetalleExposiciones
        //{
        //    get
        //    {
        //        List<DetalleExposicion> listaRetorno = new List<DetalleExposicion>();
        //        foreach (DetalleExposicion DE in _DetalleExposiciones)
        //        {
        //            listaRetorno.Add(DE);
        //        }
        //        return listaRetorno;
        //    }

        //    set => _DetalleExposiciones = value;
        //}


        private TipoExposicion _tipoExposicion;
        private Empleado _empleado;
        private Publico _publicoDestino;
       

        private IExposicion dao;

        public Exposicion()
        {
            dao = new ExposicionDao();
        }

        public List<Exposicion> Exposiciones = new List<Exposicion>();
        public List<Exposicion> BuscarListaDeExposiciones()
        {
           return dao.BuscarListaDeExposiciones();
        }

        List<Exposicion> ListaExposicionesVigentes = new List<Exposicion>();

        private DateTime ObtenerFechaActual()
        {
            string fechaActual = DateTime.Today.ToString("d");
            return DateTime.Parse(fechaActual);
        }

        TipoExposicion tipoExposicion = new TipoExposicion();

        public List<Exposicion> getExpoVigentes(List<Exposicion> lista)
        {
            DateTime fechaHoy = ObtenerFechaActual();

          

            for( int i = 0; i < lista.Count; i++)
            {
                if (lista[i].fechaFin > fechaHoy)
                {
                    ListaExposicionesVigentes.Add(lista[i]);
                }
            }
            //ListaExposicionesVigentes = tipoExposicion.esTemporal(ListaExposicionesVigentes); // esTemporal()
            return ListaExposicionesVigentes;

           
        }
        DetalleExposicion de = new DetalleExposicion();
       
        public int BuscarDuracionExtendidaObras(List<Exposicion> lista, string tipoVisita)
        {
            int duracion = de.BuscarDuracionExtendidaObras(lista, tipoVisita); // exposicion le pide a detalle que busque la duracion extendida de las obras
            return duracion;
        }




    }
}
