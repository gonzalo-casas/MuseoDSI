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
    class Escuela
    {
        public int idEscuela { get; set; }
        public string nombre { get; set; }
        public string calle { get; set; }
        public int nroCalle { get; set; }
       
      
        public List<Escuela> ListaEscuela = new List<Escuela>();

        private IEscuela dao;

        public Escuela()
        {
            dao = new EscuelaDao();
        }

        public List<Escuela> BuscarlistaEscuelas()
        {
            return dao.BuscarlistaEscuelas();
        }
    }
}
