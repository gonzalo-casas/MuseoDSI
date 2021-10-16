using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;

namespace MuseoDSI.Clases
{
    class Usuario
    {
        Backend _BD = new Backend();
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public DateTime caducidad { get; set; }

        public List<Usuario> listaUsuarios= new List<Usuario>();

        public List<Usuario> LlenarListaUsuario()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Usuario";
            tabla = _BD.Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = int.Parse(tabla.Rows[i]["idUsuario"].ToString());
                usuario.nombre = tabla.Rows[i]["nombre"].ToString();
                usuario.contraseña = tabla.Rows[i]["contraseña"].ToString();
                
                listaUsuarios.Add(usuario);
            }
            return listaUsuarios;


        }

    }
}
