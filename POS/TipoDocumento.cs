using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS
{
    public class TipoDocumento
    {
        public DataTable Listar()
        {
            try
            {
                List<Objetos.ObjTipoDocumento> lista = new List<Objetos.ObjTipoDocumento>();
                string query = "select * from  pos_tipodocumentos";
                System.Data.DataTable dt = new Util.ConexionMy().EjecutaConsultaDt(query);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
