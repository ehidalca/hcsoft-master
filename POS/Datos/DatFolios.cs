using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.POS;


namespace HCSoft.POS.Data
{
    public class DatFolios
    {

        public List<Objetos.ObjFolios> Listar()
        {
            List<Objetos.ObjFolios> lista = new List<Objetos.ObjFolios>();
            string query = "select * from  folios";

            System.Data.DataTable dt = new Util.ConexionMy().EjecutaConsultaDt(query);
            if (dt.Rows.Count != 0)
            {
                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    Objetos.ObjFolios objfolio = new Objetos.ObjFolios(dr);
                    lista.Add(objfolio);

                }

            }
            return lista;
        }


        public int TraeFolio( int caja_id, int tipodocumento_id)
        {
            int folio = 0;

            List<Objetos.ObjFolios> lista = new List<Objetos.ObjFolios>();
            string query = "select * from  folios where caja_id=" + caja_id +" and tipo_documento_id =" + tipodocumento_id;

            System.Data.DataTable dt = new Util.ConexionMy().EjecutaConsultaDt(query);
            if (dt.Rows.Count != 0)
            {
                folio = Int32.Parse(dt.Rows[0]["folio_siguiente"].ToString());

            }

            return folio;

        }

        public bool ActualizaSiguienteFolio(int caja_id, int tipodocumento_id, int foliosiguiente)
        {
            bool retorno = false;
            int id = 0;
            string query ="UPDATE POS_FOLIOS SET FOLIO_SIGUIENTE ="+foliosiguiente +" where caja_id="+ caja_id +" and  tipo_documento_id="+ tipodocumento_id +" ";

            if (new Util.ConexionMy().EjecutaConsulta(query) != 0)
                {
                retorno = true;
            }

            return retorno;

        }
    }
}
