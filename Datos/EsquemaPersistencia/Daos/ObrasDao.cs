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
    class ObrasDao : IObras
    {
        public List<Obras> ListaObras = new List<Obras>();
        public List<Obras> LlenarListaObras()
        {

            DataTable tabla = new DataTable();
            string sql = @"SELECT *  FROM Obras ob
                        JOIN DetalleExposicion de ON(ob.idObras = de.idObra)
                         ";

            tabla = Backend.obtenerInstancia().Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Obras obra = new Obras();
                obra.idObras = int.Parse(tabla.Rows[i]["idObras"].ToString());
                obra.idExposicion = int.Parse(tabla.Rows[i]["idExposicion"].ToString());
                obra.nombre = tabla.Rows[i]["nombre"].ToString();
                obra.duracionExtendida = int.Parse(tabla.Rows[i]["duracionExtendida"].ToString());
                obra.duracionResumida = int.Parse(tabla.Rows[i]["duracionResumida"].ToString());

                ListaObras.Add(obra);
            }
            return ListaObras;

        }
    }
}
