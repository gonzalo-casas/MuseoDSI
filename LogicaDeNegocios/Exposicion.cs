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
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public string nombre { get; set; }
        public string idPublico { get; set; }

        public TipoExposicion TipoExposicion { get; set; }
        public Empleado Empleado { get; set; }
        public Publico Publico { get; set; }



        public List<DetalleExposicion> DetalleExposiciones { get; set; }
 

        private IExposicion dao;

        public Exposicion()
        {
            //dao = new ExposicionDao();
        }

        //public List<Exposicion> Exposiciones = new List<Exposicion>();
        //public List<Exposicion> BuscarListaDeExposiciones()
        //{
        //   return dao.BuscarListaDeExposiciones();
        //}

        //List<Exposicion> ListaExposicionesVigentes = new List<Exposicion>();

        private DateTime ObtenerFechaActual()
        {
            string fechaActual = DateTime.Today.ToString("d");
            return DateTime.Parse(fechaActual);
        }

        //TipoExposicion tipoExposicion = new TipoExposicion();

        public bool getExpoVigentes()
        {
            DateTime fechaHoy = ObtenerFechaActual();

            if(this.fechaFin > fechaHoy){   // si es vigente ...
               return  this.TipoExposicion.esTemporal(); // le pide a TipoExposicion si es temporal, return true si es temporal
            }
            return false;
          
                       

           
        }

        public bool getExpoVigentesCompleta()
        {
            DateTime fechaHoy = ObtenerFechaActual();

            return this.fechaFin > fechaHoy; // si es vigente devuelve true
          




        }

        public int BuscarDuracionExtendidaObra()
        {
            int duracion = 0;
            foreach (DetalleExposicion dt in this.DetalleExposiciones) // mientras haya detalles
            {
                 duracion +=  dt.BuscarDuracionExtendidaObras();
            }

            return duracion;


        }

        public int BuscarDuracionResumidaObra()
        {
            int duracion = 0;
            foreach (DetalleExposicion dt in this.DetalleExposiciones) // mientras haya detalles
            {
                duracion += dt.BuscarDuracionResumidaObras();
            }

            return duracion;


        }


        






        //public int BuscarDuracionExtendidaObras(List<Exposicion> lista, string tipoVisita)
        //{
        //    int duracion = de.BuscarDuracionExtendidaObras(lista, tipoVisita); // exposicion le pide a detalle que busque la duracion extendida de las obras
        //    return duracion;
        //}




    }
}
