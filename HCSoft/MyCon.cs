using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace HCSoft.Util
{
    public class MyCon
    {
        private string cadenaConexion = "Server=localhost; Port=3306; Database=asisthogar; Uid=root; Pwd=1234;";
        public DataTable EjecutaConsulta(String query)
        {
            try
            {  
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                MySqlDataAdapter myadap = new MySqlDataAdapter(query,conn);
                myadap.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                myadap.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable EjecutaConsulta(String query, MySqlParameter[] parametros)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                MySqlDataAdapter myadap = new MySqlDataAdapter();
                MySqlCommand cmd;
                cmd = new MySqlCommand(query, conn);

                foreach (MySqlParameter parametro in parametros) {
                    cmd.Parameters.Add(parametro);
                }

                // cmd.Parameters.AddWithValue("@id", 7);

                myadap.SelectCommand = cmd;

                DataTable dt = new DataTable();
                myadap.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public long EjecutaQueryRetornaId(string query, MySqlParameter[] parametros)
        {
            MySqlConnection connection = new MySqlConnection(cadenaConexion);
            try
            {
                connection.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand(query, connection);

                foreach (MySqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }

                cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;
                connection.Close();

                return id;
              
            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }

        }

        public bool EjecutaQuery(string query, MySqlParameter[] parametros)
        {
            MySqlConnection connection = new MySqlConnection(cadenaConexion);
            try
            {
                connection.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand(query, connection);

                foreach (MySqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }

                int id =cmd.ExecuteNonQuery();
                connection.Close();

                if (id != 0)
                {
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }

        }
    }
}

