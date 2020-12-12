using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Base
{
    public class TipoComercio
    {
        public DataTable Select()
        {
            try
            {
                return new HCSoft.Base.Data.DatTipoComercio().Select();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
