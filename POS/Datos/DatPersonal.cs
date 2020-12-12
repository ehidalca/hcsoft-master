using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.POS.Objetos;
using System.Data;

namespace HCSoft.POS.Data
{
    public  class DatPersonal
    {
        public List<ObjPersonal> Listar()
        {
            List<ObjPersonal> listapersonal = new List<ObjPersonal>();
            string query = "SELECT * FROM TBL_PERSONAL";
            DataTable dt = new ConexionMy().EjecutaConsultaDt(query);

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ObjPersonal personal = new ObjPersonal(dr);
                    listapersonal.Add(personal);
                }

            }

            return listapersonal;

        }

    }
}
