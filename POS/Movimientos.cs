using System;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS
{
    public class Movimientos
    {


        public Movimientos() { }

        public bool Genera(int productoId, int movimientoTipoId, int usuarioId)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public bool Recepcionar(long idproducto, int cantidad, string numerodocumento, int iddestino)
        {
           try
            {
                int idtipomovimiento = 1;
                
                  return   this.GeneraMovimiento(idproducto, idtipomovimiento,cantidad, numerodocumento, 0, iddestino);
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }


        public bool Mover(long idproducto, int cantidad, int idorigen, int iddestino)
        {
            try
            {
                int idtipomovimiento = 3;

                return this.GeneraMovimiento(idproducto, idtipomovimiento, cantidad, "", idorigen, iddestino);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Sacar(long idproducto, int cantidad, int idorigen)
        {
            try
            {
                int idtipomovimiento = 3;

                return this.GeneraMovimiento(idproducto, idtipomovimiento, cantidad,"", idorigen,0);
            }
            catch (Exception)
            {

                throw;
            }
        }

         

        public DataTable ListaMovimientos(DateTime fechaInicio, DateTime fechaTermino)
        {
            try
            {
              
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT m.*, t.nombre as movimiento, p.nombre as productoNombre, p.codigo productoCodigo, p.imagen  FROM movimientos m  INNER JOIN tipomovimientos t  on m.tipomovimientoId  = t.id  inner join pos_productos  p on  m.productoId = p.id  where m.fecha between '" + fechaInicio.ToString("yyyy-MM-dd") +"' and '"+ fechaTermino.ToString("yyyy-MM-dd") + "'");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable ListaMovimientosPorTipo(DateTime fechaInicio, DateTime fechaTermino, int tipoMovimientoId)
        {
            try
            {
                return new HCSoft.POS.Movimientos().ListaMovimientosPorTipo(fechaInicio, fechaTermino, tipoMovimientoId);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public DataTable ReporteMovimientos(string fecha, string fecha2)
        {
            try
            {
             string query = "SELECT * FROM  vista_movimientos where fechahora between '" + fecha + "'  and '" + fecha2 + "' ";
                        DataTable dt = new ConexionMy().EjecutaConsultaDt(query);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }   
         

        }


        public DataTable ListaMovimientosRealizados(DateTime fechaInicio, DateTime fechaTermino)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT m.id as movimientoId, m.tipoMovimientoId,  p.id as productoId, p.nombre as productoNombre, m.cantidad as cantidad , m.fecha as fecha  FROM movimientos m inner join productos p on m.productoId = p.id where m.fecha between '" + fechaInicio.ToString("yyyy-MM-dd") + "' and '" + fechaTermino.ToString("yyyy-MM-dd") + "' ");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable ListaMovimientosRealizadosPorTipoMovimiento(DateTime fechaInicio, DateTime fechaTermino, int tipoMovimientoId)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT m.id as movimientoId, m.tipoMovimientoId, t.nombre as tipoMovimiento,  p.id as productoId, p.codigo, p.nombre as productoNombre, m.cantidad as cantidad , m.fecha as fecha  FROM movimientos m inner join productos p on m.productoId = p.id inner join tipomovimientos t on m.tipoMovimientoId = t.id where m.fecha between '" + fechaInicio.ToString("yyyy-MM-dd") + "' and '" + fechaTermino.ToString("yyyy-MM-dd") + "' and tipoMovimientoID=" + tipoMovimientoId + "  ");

            }
            catch (Exception)
            {

                throw;
            }


        }


        public bool GeneraMovimiento(long productoId, long tipoMovimientoId, int cantidad, string numeroDocumento, int ubicacionOrigen, int ubicacionDestino)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                bool retorno = false;
                int id = 0;
                string query = "INSERT INTO movimientos(productoId,tipoMovimientoId,cantidad, nroDocumento, fecha,hora, ubicacionOrigen, ubicacionDestino )" +
                               "VALUES(" + productoId + "," + tipoMovimientoId + ", " + cantidad + ", '" + numeroDocumento + "','" + fecha.ToString("yyyy-MM-dd") + "','" + fecha.ToString("HH:mm:ss") + "', " + ubicacionOrigen + ", " + ubicacionDestino + ")";
                id = new ConexionMy().EjecutaConsulta(query);
                if (id != 0) { retorno = true; }

                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
           


        }
    }


}
