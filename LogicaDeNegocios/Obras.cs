using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using MuseoDSI.Datos.EsquemaPersistencia.Daos;

namespace MuseoDSI.Clases
{
    class Obras
    {
        public int idObras { get; set; }
        public int idExposicion { get; set; }
        public string nombre { get; set; }
        public int duracionExtendida { get; set; }
        public int duracionResumida { get; set; }
        public int peso { get; set; }
        public int alto { get; set; }
        public int ancho { get; set; }
        public int valuacion { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string descripcion { get; set; }

        public List<Obras> ListaObras = new List<Obras>();

        private IObras dao;
        public Obras()
        {
            dao = new ObrasDao();
        }

        public List<Obras> LlenarListaObras()
        {
            return dao.LlenarListaObras();
        }

        public int DevolverDuracionExtendida(int id)
        {
            int duracion = 0;
            for(int i = 0; i < ListaObras.Count; i++)
            {
               
                if(ListaObras[i].idObras == id)
                {
                    
                    duracion = ListaObras[i].duracionExtendida;
                }
            }
            return duracion;
        }


    }
}
