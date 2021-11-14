using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;

namespace MuseoDSI.Clases
{
    public class Publico
    {
        Backend _BD = new Backend();
        public int idPublico { get; set; }
        public string descripcion { get; set; }


        List<Publico> listaPublico = new List<Publico>();

        public string getPublico(){

            return this.descripcion;
        }


    
    }
}
