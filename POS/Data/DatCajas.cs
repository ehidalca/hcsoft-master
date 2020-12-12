using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;
using HCSoft.Util;
using HCSoft.POS.Objetos;


namespace HCSoft.POS.Data
{
   
    public class DatCajas
    {
        public DataTable Listar()
        {
            try
            {
                string query = "select pos_cajas.*, pos_sucursales.nombre as sucursal from pos_cajas inner join pos_sucursales on  pos_cajas.sucursal_id = pos_sucursales.id";
                return  new ConexionMy().EjecutaConsultaDt(query);
              
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public ObjCaja consulta(int idcaja)
        {

            ObjCaja caja = new ObjCaja();
            string query = "select * from  pos_cajas";
            DataTable dt = new  ConexionMy().EjecutaConsultaDt(query);

            if (dt.Rows.Count != 0)
            {
                caja = new ObjCaja(dt.Rows[1]);
            }

            return caja;


        }

        public DataTable Get(int CajaId)
        {
            try
            {
                string query = "SELECT * FROM cajas where id =" + CajaId;
                return new ConexionMy().EjecutaConsultaDt(query);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable Get(string nombre)
        {
            try
            {
                string query = "SELECT * FROM cajas where nombre ='" + nombre +"'";
                return new ConexionMy().EjecutaConsultaDt(query);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public int Ingresar(string nombre, int sucursalId)
        {
            try
            {
                 string query = "INSERT INTO pos_cajas(nombre,sucursal_id) VALUES('" + nombre + "'," + sucursalId + ")";
                            return  new ConexionMy().EjecutaConsulta(query);
            }
            catch (Exception)
            {

                throw;
            }
           


        }

        public int Actualizar(string nombre, int sucursalId, int cajaId)
        {
            try
            {
               
                string query = "UPDATE pos_cajas SET nombre = '" + nombre + "', sucursal_id='" + sucursalId + "' WHERE id =" + cajaId + "";
                return  new ConexionMy().EjecutaConsulta(query);

             
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Eliminar(int id)
        {
            try
            {

                string query = "UPDATE CAJAS SET estado = 0 WHERE id =" + id + "";
                return new ConexionMy().EjecutaConsulta(query);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
