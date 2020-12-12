using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;
using HCSoft.POS.Objetos;

namespace HCSoft.POS.Data
{
  public  class DatTipoMovimientos
    {
      public ObjTipoMovimiento TraerPorCodigo(string codigo)
      {
         ObjTipoMovimiento tipomovimiento = new ObjTipoMovimiento();
         string query = "SELECT IDTIPOMOVIMIENTO,CODIGO,NOMBRE FROM TBL_TIPOMOVIMIENTOS WHERE CODIGO='"+ codigo +"'";
         DataTable dt = new ConexionMy().EjecutaConsultaDt(query);
          if (dt.Rows.Count != 0)
          {
              DataRow dr = dt.Rows[0];
              tipomovimiento = new ObjTipoMovimiento(dr);

          }

          return tipomovimiento;
            
      
      }

      

    }
}
