using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Negocio
{
   public class Salones
    {
       public DataTable Listar()
       {

           return new ConexionMy().EjecutaConsultaDt("SELECT * FROM SALONES");
       
       }
    }
}
