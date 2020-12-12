using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using HCSoft.Util;

namespace HCSoft.Base
{
     public class Usuarios
    {

        public int  CrearUsuario(int empresa_id, string usuario, string correo, string clave , string nombre, string apellidos )
        {
            int id = 0;
            string sql = "INSERT INTO BASE_USUARIOS(usuario, correo, clave,nombre, apellidos, empresa_id) values('"+ usuario +"', '"+ correo +"', '"+clave+"', '"+ nombre +"', '"+ apellidos +"',"+ empresa_id+")";
            id = new ConexionMy().EjecutaConsulta(sql);
            return id;
        }

        public DataTable ListarUsuarios(int empresa_id)
        {
            try
            {
                string sql = "SELECT * FROM BASE_USUARIOS WHERE empresa_id = " + empresa_id.ToString();
                DataTable dt = new ConexionMy().EjecutaConsultaDt(sql);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
