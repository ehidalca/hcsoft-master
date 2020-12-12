using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;

namespace HCSoft.Base
{
     public  class Cliente
    {
        public int Registrar(string email, string nombre, string telefono, string movil, string direccion, int tiponegocio_id)
        {
            try
            {
                return new ConexionMy().EjecutaConsulta("INSERT INTO BASE_CLIENTES(nombre,telefono, movil, email, direccion) values('"+nombre+"','"+telefono+"','"+ movil+"','"+email +"','"+direccion+"')");
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
