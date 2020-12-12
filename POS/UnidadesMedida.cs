using System;
using System.Data;
using HCSoft.Util;
using MySql.Data.MySqlClient;

namespace HCSoft.POS
{
    public class UnidadesMedida
    {
        public DataTable Listar()
        {
            try
            {
                string query = "SELECT * FROM unidades_medida where eliminado=0";
                return new MyCon().EjecutaConsulta(query);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public DataTable Consulta(int id)
        {
            try
            {
                string query = "SELECT * FROM unidades_medida WHERE id =@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id)
                };

                return new MyCon().EjecutaConsulta(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool Crear(string nombre, int usuarioId)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "INSERT INTO unidades_medida(nombre, fecha_hora_creacion,usuario_creacion_id) VALUES(@nombre,@fecha_hora_creacion,@usuario_creacion_id)";
                MySqlParameter[] parametros = {
                    new MySqlParameter("nombre",nombre),
                    new MySqlParameter("fecha_hora_creacion", fechaHoraCreacion),
                    new MySqlParameter("usuario_creacion_id", usuarioId)
                };

                return new MyCon().EjecutaQuery(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool Actualizar(int id, string nombre, int usuarioId)
        {
            try
            {
                DateTime fechaHoraActualizacion = DateTime.Now;
                string query = "UPDATE unidades_medida SET nombre=@nombre, fecha_hora_actualizacion=@fecha_hora_actualizacion, usuario_creacion_id=@usuario_creacion_id WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id),
                    new MySqlParameter("nombre",nombre),
                    new MySqlParameter("fecha_hora_actualizacion", fechaHoraActualizacion),
                    new MySqlParameter("usuario_creacion_id", usuarioId)
                };

                return new MyCon().EjecutaQuery(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool Eliminar(int id, int usuarioId)
        {
            try
            {
                DateTime fechaHoraEliminacion = DateTime.Now;
                string query = "UPDATE unidades_medida SET eliminado=1, fecha_hora_eliminacion=@fecha_hora_eliminacion, usuario_eliminacion_id=@usuario_eliminacion_id WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id),
                    new MySqlParameter("fecha_hora_eliminacion", fechaHoraEliminacion),
                    new MySqlParameter("usuario_eliminacion_id", usuarioId)
                };

                return new MyCon().EjecutaQuery(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }



        }
    }

}