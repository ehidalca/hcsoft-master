using System;
using System.Collections.Generic;
using System.Data;


namespace HCSoft.POS
{
   public class Acceso
    {

      

        public DataTable Login(string usuario, string password)
        {
            try
            {
                string passworDesencriptada = Util.Seguridad.Encriptar(password);
                DataTable dt =  new  Util.MyCon().EjecutaConsulta("SELECT  * FROM  usuarios WHERE usuario=@usuario and password='"+ passworDesencriptada +"' ");
                return dt;


            }
            catch (Exception)
            {

                throw;
            }
           

        }

    

    }

    
}
