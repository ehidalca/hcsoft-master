using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace HCSoft.Util
{
    public class ConexionMy
    {
        private string cadenaconexion = "";

        public ConexionMy(string cadenaconexion_)
        {
            this.cadenaconexion = cadenaconexion_;
        }

        public ConexionMy()
        {
            try
            {
     
                    this.cadenaconexion = ConfigurationSettings.AppSettings["cadenaconexion"];
            }
            catch (Exception)
            {
              

            }
         

        }

        public int EjecutaConsulta(string query)
        {   MySqlConnection connection = new MySqlConnection(cadenaconexion);

            try
            {

                connection.Open();
                MySqlDataAdapter mysqldap = new MySqlDataAdapter(query, connection);
                int id = mysqldap.SelectCommand.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //mysqldap.Fill(dt);
                connection.Close();
                return id;

            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }
            
           

        }

        public bool EjecutaConsulta_(string query)
        {
            MySqlConnection connection = new MySqlConnection(cadenaconexion);

            try
            {

                connection.Open();
                MySqlDataAdapter mysqldap = new MySqlDataAdapter(query, connection);
                int id = mysqldap.SelectCommand.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //mysqldap.Fill(dt);
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

        public int EjecutaConsultaId(string query)
        {
            MySqlConnection connection = new MySqlConnection(cadenaconexion);
            connection.Open();
            MySqlDataAdapter mysqldap = new MySqlDataAdapter(query, connection);
            mysqldap.SelectCommand.ExecuteNonQuery();
            int id = Convert.ToInt32(mysqldap.SelectCommand.ExecuteScalar());
            //DataTable dt = new DataTable();
            //mysqldap.Fill(dt);}    
            connection.Close();
            return id;

        }

        public DataTable EjecutaConsultaDt(string query)
        { 
            MySqlConnection connection = new MySqlConnection(cadenaconexion);
            connection.Open();
            MySqlDataAdapter mysqldap = new MySqlDataAdapter(query, connection);
            mysqldap.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            mysqldap.Fill(dt);
            connection.Close();
            return dt;
        }
        
    }
}
