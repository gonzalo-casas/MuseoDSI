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
    class Usuario
    {

        private IUsuario dao;

        public Usuario()
        {
            dao = new UsuarioDao();
        }

        Backend _BD = new Backend();
        public string idUsuario { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public DateTime caducidad { get; set; }

        public Empleado empleado { get; set; }

        public List<Usuario> listaUsuarios= new List<Usuario>();

       /* public List<Usuario> LlenarListaUsuario()
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


        }*/

        public Array ValidarUsuario(string Id_Usuario, string Contrasena)
        {
            return dao.validarUsuario(Id_Usuario, Contrasena);
        }

    }
}
