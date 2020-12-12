using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;

namespace HCSoft.POS.Negocio
{
   public class PedidoDetalle
    {

       public bool CrearPedidoDetalle(int idpedido,int idproducto, int cantidad, int valorunitario, int valortotal)
       {
        
        string sql="INSERT INTO PEDIDO_DETALLE(idpedido,idproducto,cantidad, valorunitario, valortotal)values("+ idpedido +","+ idproducto +","+ cantidad +", "+ valorunitario +"," + valortotal +" ) ";
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
