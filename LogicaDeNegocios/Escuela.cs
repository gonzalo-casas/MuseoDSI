using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;

namespace MuseoDSI.Clases
{
    class Escuela
    {
        public int idEscuela { get; set; }
        public string nombre { get; set; }
        public string calle { get; set; }
        public int nroCalle { get; set; }
       
      
        Backend _BD = new Backend();
        public List<Escuela> ListaEscuela = new List<Escuela>();
        public List<Escuela> BuscarlistaEscuelas()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Escuela";
            tabla = _BD.Consulta(sql);
           
            for( int i = 0; i < tabla.Rows.Count; i++)
            {
                Escuela escuela = new Escuela();
                escuela.idEscuela = int.Parse(tabla.Rows[i]["idEscuela"].ToString());
                escuela.nombre = tabla.Rows[i]["nombre"].ToString();
                ListaEscuela.Add(escuela);
            }
            
            return ListaEscuela;
        }
    }
}
