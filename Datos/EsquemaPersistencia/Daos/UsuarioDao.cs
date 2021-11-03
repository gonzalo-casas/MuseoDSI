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
    class UsuarioDao : IUsuario
    {
        public Array validarUsuario(string Id_Usuario, string Contrasena)
        {
            string consulta = "SELECT * FROM Usuario WHERE idUsuario=" + Id_Usuario + " AND contraseña='" + Contrasena + "'";

            string[] array;

            DataTable tabla = Backend.obtenerInstancia().Consulta(consulta);
            if (tabla.Rows.Count > 0)
                return array = new string[1] { (string)tabla.Rows[0]["nombre"].ToString()};
            else
                return array = new string[1] { string.Empty };
        }
    }
}
