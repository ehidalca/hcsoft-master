using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Agenda
{
    public class Personal
    {
        public DataTable Listar()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM agenda_personal ");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable  consultar(int idempresa, int idpersona)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM agenda_personal where  cliente_id="+idempresa+" and idpersonal="+ idpersona +" ");
            }
            catch (Exception)
            {

                throw;
            }

        }

     
    }
}
