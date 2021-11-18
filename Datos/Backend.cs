using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MuseoDSI.Clases
{
    class Backend
    {
        private static Backend instancia;
        SqlConnection Coneccion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string Cadena_Coneccion = @"Data Source=LAPTOP-HMIEF28D\SQLEXPRESS;Initial Catalog=db_a7b308_museodsi;Integrated Security=True";

        private void Conectar()
        {
            if (Coneccion.State == ConnectionState.Closed)
            {
                Coneccion.ConnectionString = Cadena_Coneccion;
                Coneccion.Open();
                cmd.Connection = Coneccion;
                cmd.CommandType = System.Data.CommandType.Text;
            }
        }

        public static Backend obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Backend();

            }
            return instancia;
        }

        private void Desconectar()
        {
            Coneccion.Close();
        }

        public DataTable Consulta(string sql)
        {
            Conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public string Fecha()
        {
            string sql = "select convert (char(10), getdate(),103)";
            DataTable tabla = new DataTable();
            tabla = Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public int EjecutarSQL(string strSql)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = Cadena_Coneccion;
                // Abre la conexión
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }
    }
}
