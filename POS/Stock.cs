using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.POS
{
    public class Stock
    {
        public int StockPorProducto()
        {
            try
            {
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Movimiento(int productoId, int tipoMovimientoId, int cantidad)
        {
            try
            {
                if (new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO movimientos(productoId, tipoMovimientoId,cantidad) values(" + productoId + ", " + tipoMovimientoId + ", " + cantidad + ") ") != 0)
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

        public int Get(int productoId)
        {
            try
            {
                int stock = 0;
                
                
                    DataTable dt = new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM  movimientos WHERE productoId=" + productoId);
                    if (dt.Rows.Count > 0)
                    {
                        stock = Int32.Parse(dt.Rows[0]["cantidad"].ToString());
                    }
                

                return stock;
            }
            catch (Exception)
            {

                throw;
            }

        }
        
        public bool Salida(int productoId, string numerodocumento )
        {

            return true;

        }
    }
}
