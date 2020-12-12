using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCSoft.Util;

namespace HCSoft.POS
{
    public class UsuariosTipo
    {
        public DataTable Listar()
        {
            try
            {
                return new MyCon().EjecutaConsulta("SELECT * FROM usuarios_tipo ");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
