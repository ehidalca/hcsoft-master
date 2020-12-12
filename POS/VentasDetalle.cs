using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.POS
{
     public class VentasDetalle
    {
        public bool Guardar(int venta_id, int producto_id, int cantidad, int valor_unitario, int valor_total)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO detalleventas(venta_id,producto_id,cantidad, valor_unitario, valor_total) VALUES("+venta_id+","+producto_id +", "+ cantidad +", "+ valor_unitario+", "+valor_total+" )");
               
                    if (id != 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
