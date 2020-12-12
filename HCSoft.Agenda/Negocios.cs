using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Guia
{
    public class Negocio
    {
        public bool Registrar(string nombre, int tipo_id)
        {
            try
            {
                int idrespuesta = new HCSoft.Util.ConexionMy().EjecutaConsultaId("INSERT INTO NEGOCIO(nombre) VALUES('"+ nombre +"')");
                if (idrespuesta != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable Tipos()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM negocios_tipos");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable TipoPorId(int id)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM negocios_tipos where tipo_id=" + id);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
