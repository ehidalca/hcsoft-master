using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Guia
{
   public  class Ciudades
    {
        public DataTable Listar()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM ciudades");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
