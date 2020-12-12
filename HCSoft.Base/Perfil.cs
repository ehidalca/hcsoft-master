using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Base.Objetos;
using HCSoft.Base.Data;
using System.Data;

namespace HCSoft.Base
{
    public class Perfil
    {


        public DataTable GetPorUsuario(int idusuario)
        {
            try
            {
              string sql = "SELECT IDPERFIL, NOMBRE FROM VISTA_USUARIO_PERFILES where idusuario=" + idusuario;
              DataTable dt = new HCSoft.Util.ConexionMy().EjecutaConsultaDt(sql);
              return dt;

            }
            catch (Exception)
            {

                throw;
            }   
          
        }

        public DataTable ListarTodo()
        {
            try
            {

                string sql = "SELECT IDPERFIL, NOMBRE FROM PERFILES";
                DataTable dt = new HCSoft.Util.ConexionMy().EjecutaConsultaDt(sql);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
           
   

       }

        public bool ActualizarPerfil(int idusuario, List<ObjPerfil> perfiles)
        {
            string sql = "DELETE FROM USUARIOS_PERFILES WHERE usuarios_id =" + idusuario;
            new HCSoft.Util.ConexionMy().EjecutaConsulta(sql);

            foreach (ObjPerfil perfil in perfiles)
            {
                string sql2 = "INSERT INTO USUARIOS_PERFILES(usuarios_id, perfiles_idperfil) values('" + idusuario + "','" + perfil.Id + "')";
                new HCSoft.Util.ConexionMy().EjecutaConsulta(sql2);
            }

            return true;

        }


    }
}
