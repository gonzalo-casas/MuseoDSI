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
    class EscuelaDao : IEscuela
    {
        public List<Escuela> ListaEscuela = new List<Escuela>();
        public List<Escuela> BuscarlistaEscuelas()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Escuela";
            tabla = Backend.obtenerInstancia().Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
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
