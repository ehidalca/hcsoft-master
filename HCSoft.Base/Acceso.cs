using System;
using System.Collections.Generic;
using HCSoft.Base.Objetos;
using HCSoft.Base.Data;

using System.Data;


namespace HCSoft.Base
{
   public class Acceso
    {

      

        public DataTable Login(string usuario, string password)
        {
            string passworDesencriptada = HCSoft.Util.Seguridad.Encriptar(password);
            DataTable dt =  new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT  * FROM base_usuarios WHERE usuario='" + usuario + "' and clave='"+ passworDesencriptada +"' ");
            return dt;

        }

        public DataTable RolesListar(int idusuario)
       { 
       try 
	    {
            return new Perfil().GetPorUsuario(idusuario);
	    }
	catch (Exception)
	{
		
		throw;
	}
       }

    }

    
}
