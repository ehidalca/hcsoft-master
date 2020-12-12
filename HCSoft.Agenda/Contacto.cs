using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Agenda
{
   public class Contacto
    {

        public bool Registrar(string nombre, string email, int negocio_id)
        {
            try
            {
                int resultado = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO negocios_contacto(nombre, email,negocio_id) values('" + nombre+"', '"+ email +"', "+ negocio_id+")");
                if (resultado !=0)
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
