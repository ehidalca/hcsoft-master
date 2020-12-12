using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Agenda;
using System.Data;

namespace HCSoft.Agenda
{
   public  class Especialidades
    {
        public DataTable  Listar(int idempresa, int idcategoria)
        {
            try
            {
                return new DataTable();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Guardar(int idcliente, string nombre, int idcategoria)
        {
            try
            {
                int idresultado = 0;

                if (idresultado != 0)
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

        public bool Actualizar(int idcliente, string nombre, int idcategoria)
        {
            try
            {
                int idresultado = 0;

                if (idresultado != 0)
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
