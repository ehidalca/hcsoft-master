using System;
using System.Data;
using MySql.Data.MySqlClient;
using HCSoft.Util;


namespace HCSoft.POS
{
    public class Usuarios
    {
     

        public Usuarios()
        { }

        public DataTable Listar()
        {

            try
            {
                string query = "SELECT  * FROM usuarios WHERE eliminado=0";
            
                return new MyCon().EjecutaConsulta(query);

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public DataTable Consultar(string usuario)
        {
            try
            {

                string query = "SELECT * FROM usuarios where usuario =@usuario";
                MySqlParameter[] parametros = {
                    new MySqlParameter("usuario", usuario)
                };

                return new MyCon().EjecutaConsulta(query, parametros );

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
                string query = "SELECT  * FROM usuarios WHERE id=@id";
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

        public bool Crear(string nombre, string email, string usuario,string imagen, string password, int tipoUsuarioId, int usuarioId)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "INSERT INTO usuarios(nombre, email, usuario, imagen, password, tipo_usuario_id, fecha_hora_creacion,usuario_creacion_id) VALUES(@nombre, @email,@usuario,@imagen,@password,@tipo_usuario_id,@fecha_hora_creacion,@usuario_creacion_id)";

                MySqlParameter[] parametros = {
                    new MySqlParameter("nombre",nombre),
                    new MySqlParameter("email", email),
                    new MySqlParameter("usuario", usuario),
                    new MySqlParameter("imagen", imagen),
                    new MySqlParameter("password", password),
                    new MySqlParameter("tipo_usuario_id", tipoUsuarioId),
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

        public bool Actualizar(int id, string nombre, string email, string usuario, string password, int tipoUsuarioId, int usuarioId)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "UPDATE usuarios SET nombre=@nombre, email=@email, usuario=@usuario, password=@password, tipo_usuario_id=@tipo_usuario_id, fecha_hora_actualizacion=@fecha_hora_actualizacion ,usuario_actualizacion_id = @usuario_actualizacion_id WHERE id =@id ";

                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id),
                    new MySqlParameter("nombre",nombre),
                    new MySqlParameter("email", email),
                    new MySqlParameter("usuario", usuario),
                    new MySqlParameter("password", password),
                    new MySqlParameter("tipo_usuario_id", tipoUsuarioId),
                    new MySqlParameter("fecha_hora_actualizacion", fechaHoraCreacion),
                    new MySqlParameter("usuario_actualizacion_id",usuarioId)
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
