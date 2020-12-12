using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Agenda
{
    public class Servicios
    {
        public DataTable Listar()
        {
            try
            {
               return   new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM agencia_servicios where estado=1");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool Actualizar(string nombre, int servicioId, int categoriaId)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE agencia_servicios SET nombre='" + nombre + "', categoriaId="+ categoriaId +" WHERE id =" + servicioId);
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
        public bool Eliminar(int servicioId)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE agencia_servicios SET estado=0 WHERE id =" + servicioId);
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
        public bool Ingresar(string nombre, int categoriaId)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT agencia_servicios(nombre, categoriaId) VALUES('"+ nombre +"', '"+ categoriaId +"') ");
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
