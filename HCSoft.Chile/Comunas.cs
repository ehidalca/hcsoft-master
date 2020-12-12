using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Guia
{
    public  class Comunas
    {
        public DataTable Listar(int ciudad_id)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM comunas WHERE ciudad_id =" + ciudad_id + "");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
