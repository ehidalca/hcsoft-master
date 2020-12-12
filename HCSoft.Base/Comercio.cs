using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Base.Objetos;

namespace HCSoft.Base
{
    public  class Comercio
    {
        public bool Insert(ObjComercio comercio)
        {
            try
            {
                return new Data.DatComercio().Insert(comercio);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable Select(string email)
        {
            try
            {
                return new HCSoft.Base.Data.DatComercio().Select(email);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
