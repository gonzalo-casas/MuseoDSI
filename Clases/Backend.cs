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
        SqlConnection Coneccion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string Cadena_Coneccion = "Data Source=LAPTOP-C87F44FH;Initial Catalog=Museo;Integrated Security=True";

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
    }
}
