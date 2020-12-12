using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.POS.Objetos;
using System.Data;


namespace HCSoft.POS.Data
{
   public class DatServicios
    {
       public List<ObjServicio> Listar()
       {
           List<ObjServicio> listaservicios = new List<ObjServicio>();
           string query = "SELECT * FROM TBL_SERVICIOS";
           DataTable dt = new ConexionMy().EjecutaConsultaDt(query);

           if (dt.Rows.Count != 0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   ObjServicio servicio = new ObjServicio(dr);
                   listaservicios.Add(servicio);
               }

           }

           return listaservicios;

       }
    }
}
