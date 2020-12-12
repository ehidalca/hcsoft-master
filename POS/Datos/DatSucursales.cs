using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;
using HCSoft.POS.Objetos;

namespace HCSoft.POS.Data
{
    public class DatSucursales
    {
        public DataTable Listar()
        {
            try
            {
               return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM pos_sucursales where estado=1");
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
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM sucursales where nombre ='"+ nombre+"'");
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
                return new ConexionMy().EjecutaConsulta("UPDATE sucursales  SET estado =0  WHERE id=" + id + "");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
