using System;
using HCSoft.POS.Objetos;
using HCSoft.Util;
using System.Data;
using MySql.Data.MySqlClient;

namespace HCSoft.POS
{
    public class Sucursales
    {
        private int usuarioId;

        public Sucursales()
        { 
        }

        public Sucursales(int usuarioId)
        {
            this.usuarioId = usuarioId;
        }

        public DataTable Listar()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM sucursales where estado=1");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable Consultar(int id)
        {
            try
                {
                
                string query = "SELECT * FROM  sucursales WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id)
                };

                return new MyCon().EjecutaConsulta(query, parametros);

            }
            catch (Exception)
                {

                    throw;
                }
        }

        public DataTable Get(string nombre)
                {
                    try
                    {
                        return new HCSoft.POS.Data.DatSucursales().Get(nombre);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

        public bool Crear(string nombre, string direccion,string telefono, string encargado)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "insert into sucursales(nombre, direccion, telefono, encargado, fecha_hora_creacion, usuario_creacion_id) values(@nombre,@direccion,@telefono, @encargado, @fechaHoraCreacion,@usuarioCreacionId)";
                MySqlParameter[] parametros = {
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("direccion", direccion),
                    new MySqlParameter("telefono", telefono),
                    new MySqlParameter("encargado", encargado),
                    new MySqlParameter("fechaHoraCreacion", fechaHoraCreacion),
                    new MySqlParameter("usuarioCreacionId",this.usuarioId)
                };

                return new MyCon().EjecutaQuery(query, parametros);
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Actualizar(int id, string nombre, string direccion, string telefono, string encargado, int usuarioId)
        {

            try
            {
                DateTime fechaHoraActualizacion = DateTime.Now;
                string query = "UPDATE sucursales SET nombre=@nombre, direccion=@direccion, telefono=@telefono, encargado=@encargado, fecha_hora_actualizacion=@fechaHoraActualizacion, usuario_actualizacion_id=@usuarioActualizacionId WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id),
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("direccion", direccion),
                    new MySqlParameter("telefono", telefono),
                    new MySqlParameter("encargado", encargado),
                    new MySqlParameter("fechaHoraActualizacion", fechaHoraActualizacion),
                    new MySqlParameter("usuarioActualizacionId", usuarioId)
                };

                return new MyCon().EjecutaQuery(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Eliminar(int id)
        {

            try
            {
                if (new HCSoft.POS.Data.DatSucursales().Eliminar(id) != 0)
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
