using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Negocio
{
   public class Personal
    {

       public DataTable Listar()
       {

           return new ConexionMy().EjecutaConsultaDt("Select *, CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno)  as persona  from Personal");

       
       }

    }
}
