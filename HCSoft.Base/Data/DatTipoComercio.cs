using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using System.Data;

namespace HCSoft.Base.Data
{
     public class DatTipoComercio
    {
        /// <summary>
        /// Retornada todos los tipos de comercios disponibles
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("select * from base_comercio_tipos");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
