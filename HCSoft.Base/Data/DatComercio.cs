using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Base.Objetos;

namespace HCSoft.Base.Data
{
    public class DatComercio
    {
        public bool Insert(ObjComercio comercio)
        {
            try
            {
                int resultado = 0;
                DateTime fecha = DateTime.Now;
                resultado = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO base_comercios(email,password,base_tipo_comercio_id,fecha_registro) VALUES('" + comercio.Email + "','" + comercio.Password + "'," + comercio.TipoComercioId + ", '"+ fecha.ToString("yyyy-MM-dd H:mm:ss")+"')");
                if (resultado !=0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Selecciona comercio por email
        /// </summary>
        /// <param name="email">email </param>
        /// <returns></returns>
        public DataTable Select(string email)
        {
            try
            {
                
                return  new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM base_comercios where email ='"+ email +"'");
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
