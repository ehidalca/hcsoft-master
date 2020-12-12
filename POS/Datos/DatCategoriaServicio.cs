using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.POS.Objetos;
using System.Data;


namespace HCSoft.POS.Data
{
  public  class DatCategoriaServicio
    {
      public List<ObjCategoriaServicio> Listar(long idempresa)
      {
          List<ObjCategoriaServicio> listacategorias = new List<ObjCategoriaServicio>();
          string query = "SELECT * FROM TBL_CATEGORIAS_SERVICIOS WHERE Activo=1 AND IdEmpresa=" + idempresa.ToString() + "";
          DataTable dt = new ConexionMy().EjecutaConsultaDt(query);
          foreach (DataRow dr in dt.Rows)
          {
              ObjCategoriaServicio objcategoria = new ObjCategoriaServicio(dr);
              listacategorias.Add(objcategoria);
          }

          return listacategorias;
      
      }
    }
}
