using System;
using HCSoft.Base.Objetos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.Base
{
    public class Menu
    {
        public DataTable  ListarItems(int idusuario)
        {
            try
            {
             string sql ="select m.id as menu_id, m.nombre as nombre,  m.url as url , m.idpadre as idpadre, menuprincipal from menu m inner join usuarios_accesos ua on  m.id = ua.idmenu   where ua.idusuario = " +  idusuario.ToString() +"";

             return  new ConexionMy().EjecutaConsultaDt(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable ListaMenuPorPagina(string nombre, int idusuario)
        {
            try
            {
                int idmenupadre = 0;
                DataTable  dtmenu = new HCSoft.Util.ConexionMy().EjecutaConsultaDt("select * from menu  where nombre ='" + nombre  +"'");
                if (dtmenu.Rows.Count > 0)
                {
                     idmenupadre = Int32.Parse(dtmenu.Rows[0]["Id"].ToString());

                }

                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("select m.id as menu_id, m.nombre as nombre,  m.url as url , m.idpadre as idpadre from menu m inner join usuarios_accesos ua on  m.id = ua.idmenu  where ua.idusuario = " + idusuario + " and idpadre = '" + idmenupadre + "'");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
