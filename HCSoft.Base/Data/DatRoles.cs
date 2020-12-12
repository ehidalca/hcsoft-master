using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.Base.Objetos;
using System.Data;


namespace HCSoft.Base.Data
{
     public  class DatRoles
    {
         public List<ObjRol> GetPorUsuario(int idusuario)
         {
             List<ObjRol> roles = new List<ObjRol>();
             string sql = "SELECT * FROM VIW_USUARIOS_ROL WHERE idusuario =" + idusuario;
             DataTable dt = new ConexionMy().EjecutaConsultaDt(sql);
             if (dt.Rows.Count != 0)
             {
                 foreach (DataRow dr in dt.Rows)
                 {
                     ObjRol rol = new ObjRol(dr);
                     roles.Add(rol);
                 }
             }

             return roles;

         }
     
     }
}
