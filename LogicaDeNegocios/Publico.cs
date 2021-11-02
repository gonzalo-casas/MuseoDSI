using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;

namespace MuseoDSI.Clases
{
    class Publico
    {
        Backend _BD = new Backend();
        public string idPublico { get; set; }
        public string descripcion { get; set; }
        

        List<Publico> listaPublico = new List<Publico>();

        private void LlenarListaPublico()
        {
           
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Publico";
            tabla = _BD.Consulta(sql);
            Publico publico = new Publico();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
               
                publico.idPublico =  tabla.Rows[i]["idPublico"].ToString();
                publico.descripcion = tabla.Rows[i]["descripcion"].ToString();
                listaPublico.Add(publico);
            }
            
            // ARREGLAR ESTA SHIT -.-(falta mostrar nombre en vez del id xd)
        }
       public  List<Exposicion> ObtenerPublico(List<Exposicion> lista)
        {
            listaPublico.Clear();
            LlenarListaPublico();
            for(int i = 0;i < lista.Count; i++)
            {
                for(int j = 0; j < listaPublico.Count; j++)
                {
                    string id1 = lista[i].idPublico;
                    string id2 = listaPublico[j].idPublico;
                    
                    if(id1 == id2)
                    {
                        Exposicion NuevaExpo = new Exposicion { idPublico = listaPublico[j].idPublico, fechaInicio = lista[i].fechaInicio, fechaFin = lista[i].fechaFin, nombre = lista[i].nombre };
                        lista.RemoveAt(i);
                        lista.Add(NuevaExpo);
                    }
                    
                }
            }
            return lista;
        }
    }
}
