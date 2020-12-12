using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HCSoft.Util
{
    public  class Formato
    {
        public static T GetDato<T>(object value)
        {
            try
            {
                return (value == null || value.Equals(DBNull.Value) || value.Equals(string.Empty)) ? default(T) : (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
            }

            return default(T);
        }

        public string ObtieneFecha(DateTime fechahora)
        {
            return fechahora.Date.ToShortDateString();
        }

        public string ObtieneFechaMysql(DateTime fechahora)
        {
          
           return fechahora.ToString("yyyy-MM-dd");
        }

        public string ObtieneHora(DateTime fechahora)
        {
            return fechahora.Date.ToShortTimeString();
        }


     

    }
}
