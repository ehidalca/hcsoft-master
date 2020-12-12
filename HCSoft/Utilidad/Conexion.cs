using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace HCSoft.Util
{
    public class Conexion
    {
        private string cadenaconexion = "Data Source = EDUARDOHIDALGO\\SQLEXPRESS; Initial Catalog = ; Integrated Security = True";


        public int EjecutaConsulta(string query)
        {
            SqlConnection connection = new SqlConnection(cadenaconexion);
            connection.Open();
            SqlDataAdapter mysqldap = new SqlDataAdapter(query, connection);
            int id= mysqldap.SelectCommand.ExecuteNonQuery();
           // DataTable dt = new DataTable();
          //  mysqldap.Fill(dt);
            connection.Close();
            return id;

        }
        
        public DataTable EjecutaConsultaDt(string query)
        { 
            SqlConnection connection = new SqlConnection(cadenaconexion);
            connection.Open();
            SqlDataAdapter mysqldap = new SqlDataAdapter(query, connection);
            mysqldap.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            mysqldap.Fill(dt);
            connection.Close();
            return dt;
        }

        

    }
}
