using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.Base
{
   public class Acceso
    {


       public DataTable Login(string nombreusuario, string password)
       {
           try
           {
                
                DataTable dt = new ConexionMy().EjecutaConsultaDt("select * from usuarios where usuario='" + nombreusuario + "' and clave='" + password + "'");
                return dt;

           }
           catch (Exception ex)
           {
               
               throw;
           }
       
       
       }

       public DataTable  RolesListar(int idusuario)
       { 
       try 
	    {
              
                string sql = "SELECT IDPERFIL, NOMBRE FROM VISTA_USUARIO_PERFILES where idusuario=" + idusuario;
                DataTable dt = new ConexionMy().EjecutaConsultaDt(sql);

                return dt;


            }
            catch (Exception)
	{
		
		throw;
	}
       }

        public bool CerrarSesion()
        {
            return true;
        }

    }

    
}
