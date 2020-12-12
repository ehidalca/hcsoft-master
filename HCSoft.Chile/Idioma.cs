using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Guia
{
    public class Idioma
    {
        public DataTable ListaEtiquetasPorPagina(string nombrepagina)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM labels where nombrepagina ='" + nombrepagina + "' ");
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
