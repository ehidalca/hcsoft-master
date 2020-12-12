using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.POS.Negocio;
using HCSoft.Util;
using System.Data;

namespace HCSoft.POS.Negocio
{
    public class Mesas
    {
        public DataTable listar()
        {

            return new ConexionMy().EjecutaConsultaDt("SELECT * FROM MESAS");
        
        
        }

        public bool CambiarEstado(int estado, int idmesa)
        {


            string sql = " UPDATE MESAS SET estado =" + estado + " WHERE idmesa = " + idmesa + "";

            int id = 0;
            id = new ConexionMy().EjecutaConsulta(sql);
            if (id != 0)
            {
                return true;
            }
            return false;



        }

    }
}
