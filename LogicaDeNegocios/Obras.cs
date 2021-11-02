using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;

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
        Backend _BD = new Backend();
        public List<Obras> LlenarListaObras()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Obras ORDER BY duracionExtendida";
            tabla = _BD.Consulta(sql);
            
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Obras obra = new Obras();
                obra.idObras = int.Parse(tabla.Rows[i]["idObras"].ToString());
                obra.idExposicion = int.Parse(tabla.Rows[i]["idExposicion"].ToString());
                obra.nombre = tabla.Rows[i]["nombre"].ToString();
                obra.duracionExtendida = int.Parse(tabla.Rows[i]["duracionExtendida"].ToString());
                ListaObras.Add(obra);
            }
            return ListaObras;

            
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
