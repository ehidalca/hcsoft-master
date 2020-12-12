using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;
using HCSoft.POS.Objetos;

namespace HCSoft.POS.Data
{
    public class DatUnidades
    {
        

        public DataTable Listar()
        {
            try
            {
                return new ConexionMy().EjecutaConsultaDt("SELECT * FROM pos_unidadesmedidas WHERE estado=1");
            }
            catch (Exception)
            {

                throw;
            }



        }

        public bool Ingresar(string nombre)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta(" INSERT INTO  pos_unidadesmedidas(nombre,estado) VALUES('" + nombre + "', 1) ");

                if (id != 0)
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
    }
}
