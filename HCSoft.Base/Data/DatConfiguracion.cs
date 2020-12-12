using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;
using HCSoft.Base.Objetos;

namespace HCSoft.Base.Data
{
   public class DatConfiguracion
    {
       public ObjConfiguracion TraerPorNombre(string NOMBRE)
       {

           DataTable dt = new ConexionMy().EjecutaConsultaDt("SELECT id, NOMBRE, VALOR FROM configuraciones WHERE NOMBRE='" + NOMBRE + "'");
           ObjConfiguracion configuracion = new ObjConfiguracion(dt.Rows[0]);
           return  configuracion;
       
       
       }
        
    }
}
