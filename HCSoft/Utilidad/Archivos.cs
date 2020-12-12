using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HCSoft.Util
{
   public class Archivos
    {
       public bool Guardar(string rutaOrigen, string rutaDestino )
       {
           try
           {
               System.IO.File.Copy(rutaOrigen,rutaDestino, true);
               return true;
           }
           catch (Exception)
           {

               return false;
           }
           
           
       }

       public bool VerificaExistencia(string rutaarchivo)
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(rutaarchivo);
                            return File.Exists(rutaarchivo);
            }
            catch (Exception)
            {

                return false;
            }
            
       }
    }
}
