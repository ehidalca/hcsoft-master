using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;

namespace HCSoft.POS.Negocio
{
   public class Pedido
    {

       public bool CrearPedido(int idpersonal, string referencia, int idmesa)
       {
        string fecha =  DateTime.Now.ToString("yyyy-MM-dd");
        string sql="INSERT INTO PEDIDOS(idpersonal,fecha, referencia, idmesa, idestado)values("+ idpersonal +",'"+ fecha +"','"+referencia+"', '"+ idmesa +"', 1) ";
        int id = 0;
            id =  new ConexionMy().EjecutaConsulta(sql);
         if (id != 0)
         {
             new Mesas().CambiarEstado(2, idmesa);
             return true;
         }
         return false;
       }

       public bool CambiarEstado(int estado, int idpedido)
       {
        string sql=" UPDATE PEDIDOS SET idestado ="+ estado +" WHERE idpedido = "+ idpedido+ "";
      
         int id = 0;
         id =  new ConexionMy().EjecutaConsulta(sql);
         if (id != 0)
         {
             return true;
         }
         return false;
       

       
       }

    }
}
